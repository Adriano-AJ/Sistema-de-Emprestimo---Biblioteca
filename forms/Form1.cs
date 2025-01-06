 using Sistema_de_Emprestimo___Biblioteca.forms.Emprestimo;

namespace Sistema_de_Emprestimo___Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadDataAssociados();
            loadDataBooks();
        }

        private void loadDataBooks()
        {
            // Dados dos livros.
            var livros = new[]
            {
            new { Titulo = "Aventura Cósmica", Autor = "João Mendes", Editora = "HQ Galaxy", ISBN = "9781234500011" },
            new { Titulo = "Heróis do Amanhã", Autor = "Carla Teixeira", Editora = "ComicArts", ISBN = "9789876500020" },
            new { Titulo = "Guardiões da Terra", Autor = "Pedro Lima", Editora = "SuperNova HQ", ISBN = "9784561200030" },
            new { Titulo = "Sombras na Noite", Autor = "Mariana Alves", Editora = "DarkComics", ISBN = "9787891230045" },
            new { Titulo = "Mundos Paralelos", Autor = "Lucas Martins", Editora = "Multiverso Comics", ISBN = "9781928300059" }
};

            // Adicionando os livros ao banco de dados usando um laço.
            foreach (var livroData in livros)
            {
                Livro livro = Livro.CriarLivro(livroData.Titulo, livroData.Autor, livroData.Editora, long.Parse(livroData.ISBN));
                BancoDados.livros.Add(livro);
            }

        }
        private void loadDataAssociados()
        {
            // Dados dos associados.
            var associados = new[]
            {
             new { Nome = "Ana Clara", CPF = "12345678900", Sexo = "Feminino", Logradouro = "Rua das Flores, 123", Cidade = "São Paulo", Estado = "SP", Pais = "Brasil" },
            new { Nome = "Carlos Eduardo", CPF = "98765432100", Sexo = "Masculino", Logradouro = "Avenida Central, 456", Cidade = "Rio de Janeiro", Estado = "RJ", Pais = "Brasil" },
            new { Nome = "Mariana Silva", CPF = "45678912300", Sexo = "Feminino", Logradouro = "Rua das Palmeiras, 789", Cidade = "Belo Horizonte", Estado = "MG", Pais = "Brasil" },
            new { Nome = "Pedro Almeida", CPF = "32165498700", Sexo = "Masculino", Logradouro = "Praça da Paz, 10", Cidade = "Curitiba", Estado = "PR", Pais = "Brasil" },
            new { Nome = "Julia Mendes", CPF = "78912345600", Sexo = "Feminino", Logradouro = "Travessa do Sol, 50", Cidade = "Porto Alegre", Estado = "RS", Pais = "Brasil" }
            };
            // Adicionando os associados ao banco de dados usando um laço.
            foreach (var associadoData in associados)
            {
                Associados associado = Associados.CriarAssociado(
                    associadoData.Nome,
                    associadoData.CPF,
                    associadoData.Sexo,
                    associadoData.Logradouro,
                    associadoData.Cidade,
                    associadoData.Estado,
                    associadoData.Pais
                );
                BancoDados.Associado.Add(associado);
            }

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

        private void panelFormPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
