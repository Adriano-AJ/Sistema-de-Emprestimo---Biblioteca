using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo___Biblioteca
{
    internal class Emprestimos
    {
        private static int _nextId = 1;

        public int Id { get; set; }
        public int AssociadoId { get; set; }
        public List<Livro> Livros { get; set; } = new List<Livro>();
        public string LivroTitulo { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DateDevolucao { get; set; }
        public string Status { get; set; } // "Emprestado" ou "Disponível"

        public Emprestimos()
        {
            Id = _nextId++;
        }

        // Método para calcular multa com base no atraso
        public static decimal CalcularMulta(DateTime dataPrevistaDevolucao, DateTime dataRealDevolucao)
        {
            const decimal valorPorDia = 5; // Valor da multa por dia de atraso
            int diasAtraso = (dataRealDevolucao - dataPrevistaDevolucao).Days;

            return diasAtraso > 0 ? diasAtraso * valorPorDia : 0.00m;
        }

        // Método para efetuar a devolução
        public static string EfetuarDevolucao(int emprestimoId, DateTime dataDevolucaoReal)
        {
            var emprestimo = BancoDados.Emprestimos.FirstOrDefault(e => e.Id == emprestimoId);
            if (emprestimo == null) return "Empréstimo não encontrado.";

            double multa = Convert.ToDouble(CalcularMulta(emprestimo.DateDevolucao, dataDevolucaoReal));

            // Atualiza status do livro para "Disponível"
            var livro = BancoDados.livros.FirstOrDefault(l => l.Titulo == emprestimo.LivroTitulo);
            if (livro != null)
            {
                livro.Status = "Disponível";
            }

            // Remove ou atualiza o empréstimo no banco de dados
            BancoDados.Emprestimos.Remove(emprestimo);

            if (multa > 0)
            {
                var associado = BancoDados.Associado.FirstOrDefault(a => a.Id == emprestimo.AssociadoId);
                if (associado != null)
                {
                    associado.Multa += multa;
                    return $"Livro devolvido com multa de R$ {multa:0.00}.";
                }
            }

            return "Livro devolvido com sucesso!";
        }

        // Método para efetuar o pagamento da multa
        public static string PagarMulta(string cpfAssociado)
        {
            var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpfAssociado);
            if (associado == null) return "Associado não encontrado.";

            associado.Multa = 0.00;
            return "Multa paga com sucesso!";
        }

        // Método para criar empréstimo
        public static string CriarEmprestimo(int associadoId, string livroTitulo, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            var livro = BancoDados.livros.FirstOrDefault(l => l.Titulo == livroTitulo);
            if (livro == null || livro.Status == "Emprestado") return "Livro indisponível para empréstimo.";

            var emprestimo = new Emprestimos
            {
                AssociadoId = associadoId,
                LivroTitulo = livroTitulo,
                DataEmprestimo = dataEmprestimo,
                DateDevolucao = dataDevolucao,
                Status = "Emprestado"
            };

            BancoDados.Emprestimos.Add(emprestimo);

            // Atualiza status do livro
            livro.Status = "Emprestado";

            return "Empréstimo criado com sucesso!";
        }
        public static int ObterQuantidadeLivrosEmprestadosPorAssociado(int associadoId)
        {
            return BancoDados.Emprestimos
                .Where(e => e.AssociadoId == associadoId && e.Livros != null)
                .SelectMany(e => e.Livros)
                .Count();
        }
    }
}