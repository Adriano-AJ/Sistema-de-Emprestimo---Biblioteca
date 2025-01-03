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
    public partial class frmNovoEmprestimo : Form
    {
        public frmNovoEmprestimo()
        {
            InitializeComponent();
            loadDataListBook();
        }
        public void loadDataListBook()
        {
            BancoDados.livros.ForEach(livro =>
            {
                //MessageBox.Show(livro.Titulo);
                ListViewItem item = new ListViewItem(livro.Titulo);

                
                item.SubItems.Add(livro.Autor);
                item.SubItems.Add(livro.Editora);
                item.SubItems.Add(livro.Isbn.ToString());

                listViewConsultaLivro.Items.Add(item);
            }
            );
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscaLivro_TextChanged(object sender, EventArgs e)
        {
            listViewConsultaLivro.Items.Clear();

            string nomeLivro = txtBuscaLivro.Text;

            BancoDados.livros.ForEach(livro =>
            {

                if (nomeLivro == livro.Titulo)
                {
                    ListViewItem item = new ListViewItem(livro.Titulo);
                    
                    item.SubItems.Add(livro.Autor);
                    item.SubItems.Add(livro.Editora);
                    item.SubItems.Add(livro.Isbn.ToString());

                    listViewConsultaLivro.Items.Add(item);
                }

            }
            );
        }

        private void btnEfetivarEnprestimo_Click(object sender, EventArgs e)
        {
            try
            {
                string cpfAssociado = txtCpfAssociadoEmprestimo.Text;
                if (string.IsNullOrWhiteSpace(cpfAssociado))
                {
                    MessageBox.Show("Informe o CPF do associado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpfAssociado);
                if (associado == null)
                {
                    MessageBox.Show("Associado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime dataEmprestimo = DateTime.Now;
                DateTime dataDevolucao = CalcularDataDevolucao(dataEmprestimo);

                foreach (ListViewItem item in listLivrosSelecionados.Items)
                {
                    string tituloLivro = item.SubItems[0].Text;
                    var livro = BancoDados.livros.FirstOrDefault(l => l.Titulo == tituloLivro && l.Status == "Disponível");

                    if (livro != null)
                    {
                        livro.Status = "Emprestado"; 

                        var emprestimo = Emprestimos.CriarEmprestimo(dataEmprestimo, dataDevolucao, "Confirmado");
                        BancoDados.Emprestimos.Add(emprestimo);
                    }
                    else
                    {
                        MessageBox.Show($"O livro \"{tituloLivro}\" já está emprestado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("Empréstimo efetivado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listLivrosSelecionados.Items.Clear();
                loadDataListBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao efetivar o empréstimo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listLivroEmprestimo_DoubleClick(object sender, EventArgs e)
        {
            if (listViewConsultaLivro.SelectedItems.Count > 0)
            {
                if (listLivrosSelecionados.Items.Count >= 3)
                {
                    MessageBox.Show("O carrinho de empréstimos pode conter no máximo 3 livros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedItem = listViewConsultaLivro.SelectedItems[0];
                ListViewItem item = new ListViewItem(selectedItem.SubItems[0].Text);
                item.SubItems.Add(selectedItem.SubItems[1].Text);
                item.SubItems.Add(selectedItem.SubItems[2].Text);
                item.SubItems.Add(selectedItem.SubItems[3].Text);

                listLivrosSelecionados.Items.Add(item);
                listViewConsultaLivro.Items.Remove(selectedItem);
            }
        }

        private void listCarrinhoLivros_DoubleClick(object sender, EventArgs e)
        {
            if (listLivrosSelecionados.SelectedItems.Count > 0)
            {
                var selectedItem = listLivrosSelecionados.SelectedItems[0];
                ListViewItem item = new ListViewItem(selectedItem.SubItems[0].Text);
                item.SubItems.Add(selectedItem.SubItems[1].Text);
                item.SubItems.Add(selectedItem.SubItems[2].Text);
                item.SubItems.Add(selectedItem.SubItems[3].Text);

                listViewConsultaLivro.Items.Add(item);
                listLivrosSelecionados.Items.Remove(selectedItem);
            }
        }

        private DateTime CalcularDataDevolucao(DateTime dataEmprestimo)
        {
            DateTime dataDevolucao = dataEmprestimo.AddDays(3);

            while (dataDevolucao.DayOfWeek == DayOfWeek.Saturday || dataDevolucao.DayOfWeek == DayOfWeek.Sunday)
            {
                dataDevolucao = dataDevolucao.AddDays(1);
            }

            return dataDevolucao;
        }

        private void MostrarIdEmprestimo()
        {
            if (BancoDados.Emprestimos.Count > 0)
            {
                
                var ultimoEmprestimo = BancoDados.Emprestimos.Last();

                
                MessageBox.Show($"O ID do empréstimo é: {ultimoEmprestimo.Id}", "ID do Empréstimo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhum empréstimo foi registrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }


}
