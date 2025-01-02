using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Emprestimo___Biblioteca
{
    public partial class frmDeletaLivro : Form
    {
        public frmDeletaLivro()
        {
            InitializeComponent();
            

        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            AtualizarListaLivros();
        }

        // Função para atualizar os livros na ListView
        private void AtualizarListaLivros()
        {
            listLivrosCadastrados.Items.Clear(); // Limpa a lista antes de atualizar

            foreach (var livro in BancoDados.livros)
            {
                ListViewItem item = new ListViewItem(livro.Id.ToString());
                item.SubItems.Add(livro.Titulo);
                item.SubItems.Add(livro.Autor);
                item.SubItems.Add(livro.Editora);
                listLivrosCadastrados.Items.Add(item); // Adiciona o item à ListView
            }
        }

        // Excluir o livro selecionado
        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            if (listLivrosCadastrados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um livro para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pega o ID do livro selecionado
            ListViewItem itemSelecionado = listLivrosCadastrados.SelectedItems[0];
            int idLivro = int.Parse(itemSelecionado.Text);

            // Localiza o livro na base de dados
            var livroParaRemover = BancoDados.livros.FirstOrDefault(l => l.Id == idLivro);
            if (livroParaRemover != null)
            {
                // Remove o livro da lista de livros
                BancoDados.livros.Remove(livroParaRemover);

                // Atualiza a ListView após a exclusão
                AtualizarListaLivros();

                MessageBox.Show("Livro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Livro não encontrado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDeletaLivro_Load(object sender, EventArgs e)
        {
            // Atualiza a lista de livros ao carregar o formulário
            AtualizarListaLivros();
        }

        private void btnBuscarLivroDeletar_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtConsultaisbnAssociadoDeletar.Text, out long isbnBusca))
            {
                MessageBox.Show("Por favor, insira um ISBN válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca por ISBN
            var livroEncontrado = BancoDados.livros.FirstOrDefault(livro => livro.Isbn == isbnBusca);

            listLivrosCadastrados.Items.Clear();
            if (livroEncontrado != null)
            {

                ListViewItem item = new ListViewItem(livroEncontrado.Id.ToString());
                item.SubItems.Add(livroEncontrado.Titulo);
                item.SubItems.Add(livroEncontrado.Autor);
                item.SubItems.Add(livroEncontrado.Editora);
                item.SubItems.Add(livroEncontrado.Isbn.ToString());
                listLivrosCadastrados.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Nenhum livro encontrado com o ISBN informado.", "Resultados da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}