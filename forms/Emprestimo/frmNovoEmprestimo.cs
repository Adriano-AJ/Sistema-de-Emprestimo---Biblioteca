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
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(livro.Titulo);
                item.SubItems.Add(livro.Isbn.ToString());
                item.SubItems.Add(livro.Autor);
                item.SubItems.Add(livro.Editora);

                listLivroEmprestimo.Items.Add(item);
            }
            );
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscaLivro_TextChanged(object sender, EventArgs e)
        {
            listLivroEmprestimo.Items.Clear();

            string nomeLivro = txtBuscaLivro.Text;

            BancoDados.livros.ForEach(livro =>
            {
               
                //MessageBox.Show(livro.Titulo);
                if (nomeLivro == livro.Titulo)
                {
                    ListViewItem item = new ListViewItem(livro.Titulo);
                    item.SubItems.Add(livro.Isbn.ToString());
                    item.SubItems.Add(livro.Autor);
                    item.SubItems.Add(livro.Editora);

                    listLivroEmprestimo.Items.Add(item);
                }
                
            }
            );
        }
    }
}
