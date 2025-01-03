using Sistema_de_Emprestimo___Biblioteca.forms.Emprestimo;

namespace Sistema_de_Emprestimo___Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void associadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPageAssociado frmPageAssociado = new frmPageAssociado();
            frmPageAssociado.TopLevel = false;
            frmPageAssociado.FormBorderStyle = FormBorderStyle.None;
            frmPageAssociado.Dock = DockStyle.Fill;
            panelFormPrincipal.Controls.Clear();
            panelFormPrincipal.Controls.Add(frmPageAssociado);
            frmPageAssociado.Show();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPageLivro frmPageLivro = new frmPageLivro();
            frmPageLivro.TopLevel = false;
            frmPageLivro.FormBorderStyle = FormBorderStyle.None;
            frmPageLivro.Dock = DockStyle.Fill;
            panelFormPrincipal.Controls.Clear();
            panelFormPrincipal.Controls.Add(frmPageLivro);
            frmPageLivro.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovoEmprestimo frmNovoEmprestimo = new frmNovoEmprestimo();
            frmNovoEmprestimo.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarEmprestimo frmConsultarEmprestimo = new frmConsultarEmprestimo();
            frmConsultarEmprestimo.Show();
        }
    }
}
