using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Emprestimo___Biblioteca.forms.Associados;

namespace Sistema_de_Emprestimo___Biblioteca
{
    public partial class frmPageAssociado : Form
    {
        public frmPageAssociado()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmConsultaAssociado frmConsultaAssociado = new frmConsultaAssociado();
            frmConsultaAssociado.TopLevel = false;
            frmConsultaAssociado.FormBorderStyle = FormBorderStyle.None;
            frmConsultaAssociado.Dock = DockStyle.Fill;
            panelAssociado.Controls.Clear();
            panelAssociado.Controls.Add(frmConsultaAssociado);
            frmConsultaAssociado.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            frmCadastraAssociado frmCadastraAssociado = new frmCadastraAssociado();
            frmCadastraAssociado.TopLevel = false;
            frmCadastraAssociado.FormBorderStyle = FormBorderStyle.None;
            frmCadastraAssociado.Dock = DockStyle.Fill;
            panelAssociado.Controls.Clear();
            panelAssociado.Controls.Add(frmCadastraAssociado);
            frmCadastraAssociado.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
