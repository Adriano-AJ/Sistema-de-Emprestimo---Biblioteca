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
    public partial class frmPageLivro : Form
    {

        public frmPageLivro()
        {
            InitializeComponent();
        }


        private void frmPageLivro_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            frmCadastraLivro frmCadastraLivro = new frmCadastraLivro();
            frmCadastraLivro.TopLevel = false;
            frmCadastraLivro.FormBorderStyle = FormBorderStyle.None;
            frmCadastraLivro.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(frmCadastraLivro);
            frmCadastraLivro.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmConsultaLivro frmConsultaLivro = new frmConsultaLivro();
            frmConsultaLivro.TopLevel = false;
            frmConsultaLivro.FormBorderStyle = FormBorderStyle.None;
            frmConsultaLivro.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(frmConsultaLivro);
            frmConsultaLivro.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            frmDeletaLivro frmDeletaLivro = new frmDeletaLivro();
            frmDeletaLivro.TopLevel = false;
            frmDeletaLivro.FormBorderStyle= FormBorderStyle.None;
            frmDeletaLivro.Dock = DockStyle.Fill;  
            panel1.Controls.Clear();
            panel1.Controls.Add(frmDeletaLivro);
            frmDeletaLivro.Show();
        }
    }
}
