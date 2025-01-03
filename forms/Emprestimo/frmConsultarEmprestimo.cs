using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Emprestimo___Biblioteca.forms.Emprestimo
{
    public partial class frmConsultarEmprestimo : Form
    {
        public frmConsultarEmprestimo()
        {
            InitializeComponent();
        }

        private void btnConsultarEmprestimo_Click(object sender, EventArgs e)
        {
            string cpfAssociado = txtCPFAssociado.Text;

            // Validar se o CPF foi informado
            if (string.IsNullOrWhiteSpace(cpfAssociado))
            {
                MessageBox.Show("Informe o CPF do associado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar o associado
            var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpfAssociado);
            if (associado == null)
            {
                MessageBox.Show("Associado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpar a lista de empréstimos
            listEmprestimoAssociado.Items.Clear();

            // Buscar os empréstimos do associado
            var emprestimos = BancoDados.Emprestimos.Where(e => e.Id == associado.Id).ToList();

            if (emprestimos.Count == 0)
            {
                MessageBox.Show("Nenhum empréstimo encontrado para este associado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Adicionar os empréstimos na lista
            foreach (var emprestimo in emprestimos)
            {
                var livro = BancoDados.livros.FirstOrDefault(l => l.Id == emprestimo.Id);

                ListViewItem item = new ListViewItem(emprestimo.Id.ToString());
                item.SubItems.Add(associado.CPF);
                item.SubItems.Add(associado.Nome);
                item.SubItems.Add(livro?.Titulo ?? "N/A");
                item.SubItems.Add(associado.Multa.ToString("C"));
                item.SubItems.Add(emprestimo.DataEmprestimo.ToShortDateString());
                item.SubItems.Add(emprestimo.DateDevolucao.ToShortDateString());

                listEmprestimoAssociado.Items.Add(item);
            }
        }

        private void btnPagarMulta_Click(object sender, EventArgs e)
        {

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (listEmprestimoAssociado.SelectedItems.Count > 0)
            {
                var selectedItem = listEmprestimoAssociado.SelectedItems[0];
                int emprestimoId = int.Parse(selectedItem.SubItems[0].Text);

                var emprestimo = BancoDados.Emprestimos.FirstOrDefault(e => e.Id == emprestimoId);
                if (emprestimo != null)
                {
                    emprestimo.Status = "Devolvido";

                    var livro = BancoDados.livros.FirstOrDefault(l => l.Titulo == selectedItem.SubItems[3].Text);
                    if (livro != null)
                    {
                        livro.Status = "Disponível";
                    }

                    MessageBox.Show("Livro devolvido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void listEmprestimoAssociado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEmprestimoAssociado.SelectedItems.Count > 0)
            {
                var selectedItem = listEmprestimoAssociado.SelectedItems[0];

                // Preencher o ID do empréstimo
                txtIdEmprestimo.Text = selectedItem.SubItems[0].Text;

                // Preencher o valor da multa
                txtValorMulta.Text = selectedItem.SubItems[4].Text;
            }
        }
    }
}
