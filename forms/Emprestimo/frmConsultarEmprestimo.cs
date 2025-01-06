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
            string cpf = txtCPFAssociado.Text.Trim();

            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Informe o CPF do associado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpf);
            if (associado == null)
            {
                MessageBox.Show("Associado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double valorPago = double.Parse(txtValorMulta.Text.Replace("R$", "").Trim());
                bool quitado = associado.QuitarMultas(valorPago);

                if (quitado)
                {
                    MessageBox.Show("Multa quitada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarStatusBotoes(associado);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe um valor válido para a multa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao quitar multa: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateSelectConsultar.Value.ToString());
            if (listEmprestimoAssociado.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um empréstimo para devolução.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedItem = listEmprestimoAssociado.SelectedItems[0];
            int emprestimoId = int.Parse(selectedItem.SubItems[0].Text);

            string resultado = Emprestimos.EfetuarDevolucao(emprestimoId, dateSelectConsultar.Value);
            MessageBox.Show(resultado, "Devolução", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Atualiza a lista de empréstimos
            PreencherListaEmprestimos(txtCPFAssociado.Text.Trim());
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

                string cpfAssociado = selectedItem.SubItems[1].Text;

                var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpfAssociado);

                AtualizarStatusBotoes(associado);
            }
        }

        private void PreencherListaEmprestimos(string cpfAssociado)
        {
            try
            {
                // Limpar itens existentes na lista
                listEmprestimoAssociado.Items.Clear();

                // Buscar associado pelo CPF
                var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpfAssociado);

                if (associado == null)
                {
                    MessageBox.Show("Associado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                // Filtrar os empréstimos desse associado
                var emprestimosAssociado = BancoDados.Emprestimos.Where(e => e.AssociadoId == associado.Id).ToList();

                // Adicionar os empréstimos na lista
                foreach (var emprestimo in emprestimosAssociado)
                {
                    var livro = BancoDados.livros.FirstOrDefault(l => l.Titulo == emprestimo.LivroTitulo);
                    string multa = Emprestimos.CalcularMulta(emprestimo.DateDevolucao, DateTime.Now).ToString("C");
                    string livrosConcatenados = string.Join(", ", emprestimo.Livros);

                    ListViewItem item = new ListViewItem(emprestimo.Id.ToString()); // ID do empréstimo
                    item.SubItems.Add(associado.CPF);                              // CPF do associado
                    item.SubItems.Add(associado.Nome);                             // Nome do associado
                    item.SubItems.Add(livrosConcatenados);                     // Título do livro
                    item.SubItems.Add(multa);                                      // Multa (se houver)
                    item.SubItems.Add(emprestimo.DataEmprestimo.ToShortDateString()); // Data do empréstimo

                    listEmprestimoAssociado.Items.Add(item);
                }

                if (emprestimosAssociado.Count == 0)
                {
                    MessageBox.Show("Nenhum empréstimo encontrado para este associado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar a lista de empréstimos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AtualizarStatusBotoes(Sistema_de_Emprestimo___Biblioteca.Associados associado)
        {
            if (associado == null)
            {
                btnDevolver.Enabled = false;
                btnPagarMulta.Enabled = false;
                return;
            }

            // Verifica se o associado tem multa
            if (associado.Multa > 0)
            {
                btnDevolver.Enabled = false;  // Bloqueia devolução
                btnPagarMulta.Enabled = true; // Permite pagamento
            }
            else
            {
                btnDevolver.Enabled = true;  // Permite devolução
                btnPagarMulta.Enabled = false; // Bloqueia pagamento
            }
        }

        private void dateSelectConsultar_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataSelecionada = dateSelectConsultar.Value;



            Emprestimos.CalcularMulta(dateSelectConsultar);


        }
    }
}

