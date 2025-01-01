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
    public partial class frmCadastraLivro : Form
    {
         
        public frmCadastraLivro()
        {
            InitializeComponent();
        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            
            string titulo, editora, autor;
            long isbn;

            
            try
            {
                if (string.IsNullOrWhiteSpace(txtTituloLivro.Text))
                    throw new ArgumentException("O título do livro não pode ser vazio.");
                if (string.IsNullOrWhiteSpace(txtNomeEditoraLivro.Text))
                    throw new ArgumentException("A editora do livro não pode ser vazia.");
                if (string.IsNullOrWhiteSpace(txtNomeAutorLivro.Text))
                    throw new ArgumentException("O autor do livro não pode ser vazio.");
                if (!long.TryParse(txtIsbnLivro.Text, out isbn) || txtIsbnLivro.Text.Length != 13)
                    throw new ArgumentException("O ISBN deve ter 13 números.");

                titulo = txtTituloLivro.Text;
                editora = txtNomeEditoraLivro.Text;
                autor = txtNomeAutorLivro.Text;
                isbn = long.Parse(txtIsbnLivro.Text);

                Livro livro =  Livro.CriarLivro(titulo, autor, editora, isbn);
                BancoDados.livros.Add(livro);

                ListViewItem item = new ListViewItem(livro.Id.ToString());

                item.SubItems.Add(livro.Titulo);
                item.SubItems.Add(livro.Autor); 
                item.SubItems.Add(livro.Editora);

                listLivrosCadastrados.Items.Add(item);

                MessageBox.Show("Livro cadastrado com sucesso!", "Cadastro de Livro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtTituloLivro.Clear();
                txtNomeEditoraLivro.Clear();
                txtNomeAutorLivro.Clear();
                txtIsbnLivro.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
