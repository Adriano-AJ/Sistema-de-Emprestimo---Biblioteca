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
                // Verificar se o CPF foi informado
                string cpfAssociado = txtCpfAssociadoEmprestimo.Text.Trim();
                if (string.IsNullOrWhiteSpace(cpfAssociado))
                {
                    MessageBox.Show("Informe o CPF do associado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Buscar associado
                var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpfAssociado);
                if (associado == null)
                {
                    MessageBox.Show("Associado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar multas pendentes
                if (associado.Multa > 0)
                {
                    MessageBox.Show("O associado possui multas pendentes. Regularize antes de efetivar o empréstimo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar limite de empréstimos
                int livrosAtualmenteEmprestados = BancoDados.Emprestimos
                    .Where(e => e.AssociadoId == associado.Id && e.Status == "confirmado")
                    .SelectMany(e => e.Livros)
                    .Count();

                if (livrosAtualmenteEmprestados + listLivrosSelecionados.Items.Count > 3)
                {
                    MessageBox.Show($"O associado já possui {livrosAtualmenteEmprestados} livro(s) emprestado(s). Limite máximo: 3 livros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Criar um único empréstimo com todos os livros
                DateTime dataEmprestimo = DateTime.Now;
                DateTime dataDevolucao = CalcularDataDevolucao(dataEmprestimo);

                Emprestimos novoEmprestimo = new Emprestimos
                {
                    Id = BancoDados.Emprestimos.Count + 1, // Gera um novo ID incremental
                    AssociadoId = associado.Id,
                    DataEmprestimo = dataEmprestimo,
                    DateDevolucao = dataDevolucao,
                    Status = "confirmado",
                    Livros = new List<Livro>()
                };

                foreach (ListViewItem item in listLivrosSelecionados.Items)
                {
                    string tituloLivro = item.SubItems[0].Text;
                    var livro = BancoDados.livros.FirstOrDefault(l => l.Titulo == tituloLivro);

                    if (livro != null && livro.Status.ToLower() == "disponível")
                    {
                        livro.Status = "emprestado"; // Atualiza o status do livro
                        novoEmprestimo.Livros.Add(livro); // Adiciona o livro ao empréstimo
                    }
                    else
                    {
                        MessageBox.Show($"O livro '{tituloLivro}' não está disponível para empréstimo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                BancoDados.Emprestimos.Add(novoEmprestimo);
                MessageBox.Show("Empréstimo efetivado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listLivrosSelecionados.Items.Clear();
                MostrarIdEmprestimo();
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
