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
    public partial class frmConsultaLivro : Form
    {
        public frmConsultaLivro()
        {
            InitializeComponent();
        }

        private void btnBuscarLivroNome_Click(object sender, EventArgs e)
        {
            string nomeBusca = txtConsultaNomeLivro.Text.ToLower();

            if (string.IsNullOrWhiteSpace(nomeBusca))
            {
                MessageBox.Show("Por favor, insira um nome para buscar.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var resultados = BancoDados.livros.Where(livro => livro.Titulo.ToLower().Contains(nomeBusca)).ToList();

            listViewConsultaLivro.Items.Clear();
            if (resultados.Any())
            {
                foreach (var livro in resultados)
                {

                    ListViewItem item = new ListViewItem(livro.Id.ToString());
                    item.SubItems.Add(livro.Titulo);
                    item.SubItems.Add(livro.Autor);
                    item.SubItems.Add(livro.Editora);
                    item.SubItems.Add(livro.Isbn.ToString());
                    item.SubItems.Add(livro.Status.ToString());
                    listViewConsultaLivro.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nenhum livro encontrado com o nome informado.", "Resultados da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarLivroIsbn_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtConsultaIsbnLivro.Text, out long isbnBusca))
            {
                MessageBox.Show("Por favor, insira um ISBN válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca por ISBN
            var livroEncontrado = BancoDados.livros.FirstOrDefault(livro => livro.Isbn == isbnBusca);

            listViewConsultaLivro.Items.Clear();
            if (livroEncontrado != null)
            {

                ListViewItem item = new ListViewItem(livroEncontrado.Id.ToString());
                item.SubItems.Add(livroEncontrado.Titulo);
                item.SubItems.Add(livroEncontrado.Autor);
                item.SubItems.Add(livroEncontrado.Editora);
                item.SubItems.Add(livroEncontrado.Isbn.ToString());
                item.SubItems.Add(livroEncontrado.Status.ToString());
                listViewConsultaLivro.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Nenhum livro encontrado com o ISBN informado.", "Resultados da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimparListaLivro_Click(object sender, EventArgs e)
        {
            listViewConsultaLivro.Items.Clear();
        }

        private void btnAtualizarConsultaLivro_Click(object sender, EventArgs e)
        {
            // Lógica para atualizar a consulta do livro
            MessageBox.Show("Atualizar consulta do livro ainda não implementado.");
        }

    }
}
