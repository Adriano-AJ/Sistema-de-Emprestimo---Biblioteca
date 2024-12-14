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

        private void frmCadastraLivro_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarLivro_Click(object sender, EventArgs e)
        {
            
            string titulo, editora, autor;
            long isbn;

            //MELHORAR O TRATAMENTO DOS ERROS
            try
            {
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
