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

        public double Multa { get; set; }

        public Emprestimos()
        {
            Id = _nextId++;
        }

        // Método para calcular multa com base no atraso
        public static double CalcularMulta(DateTime dataEmprestimo, DateTime dataDevolucao, int quantidadeLivros, List<DateTime> feriados)
        {
            if (dataDevolucao <= dataEmprestimo)
            {
                return 0; // Sem multa
            }

            int diasAtraso = 0;
            DateTime dataAtual = dataEmprestimo;

            while (dataAtual < dataDevolucao)
            {
                dataAtual = dataAtual.AddDays(1);

                // Ignorar finais de semana e feriados
                if (dataAtual.DayOfWeek != DayOfWeek.Saturday &&
                    dataAtual.DayOfWeek != DayOfWeek.Sunday &&
                    !feriados.Contains(dataAtual))
                {
                    diasAtraso++;
                }
            }

            double multaPorLivro = 5.0; // Valor fixo por livro por dia útil
            return Convert.ToDouble(diasAtraso * multaPorLivro * quantidadeLivros);
        }

        // Método para efetuar a devolução
        public static string EfetuarDevolucao(int emprestimoId, DateTime dataDevolucaoReal, List<DateTime> feriados)
        {
            // Encontrar o empréstimo pelo ID
            var emprestimo = BancoDados.Emprestimos.FirstOrDefault(e => e.Id == emprestimoId);
            if (emprestimo == null)
                return "Empréstimo não encontrado.";

            // Calcular multa considerando feriados e dias úteis
            Double multa = CalcularMulta(emprestimo.DateDevolucao, dataDevolucaoReal, emprestimo.Livros.Count, feriados);

            // Atualizar o status dos livros para "Disponível"
            foreach (var livro in emprestimo.Livros)
            {
                var livroNoBanco = BancoDados.livros.FirstOrDefault(l => l.Titulo == livro.Titulo);
                if (livroNoBanco != null)
                {
                    livroNoBanco.Status = "Disponível";
                }
            }

            // Atualizar a multa do associado, se necessário


            // Remover o empréstimo do banco de dados
            BancoDados.Emprestimos.Remove(emprestimo);

            // Retornar mensagem adequada
            return multa > 0
                ? $"Livro(s) devolvido(s) com multa de R$ {multa:0.00}."
                : "Livro(s) devolvido(s) com sucesso!";
        }

        // Método para efetuar o pagamento da multa
        public static string PagarMulta(string cpfAssociado)
        {
            // Buscar o associado
            var associado = BancoDados.Associado.FirstOrDefault(a => a.CPF == cpfAssociado);
            if (associado == null)
                return "Associado não encontrado.";

            // Verificar se o associado tem algum empréstimo com multa
            var emprestimoComMulta = BancoDados.Emprestimos.FirstOrDefault(e => e.AssociadoId == associado.Id && e.Multa > 0);

            if (emprestimoComMulta == null)
                return "Não há multas pendentes para este associado.";

            // Zerar a multa do empréstimo
            emprestimoComMulta.Multa = 0;

            // Atualizar o empréstimo no banco de dados
            BancoDados.AtualizarEmprestimo(emprestimoComMulta);

            return "Multa paga com sucesso!";
        }

        // Método para criar empréstimo
        public static string CriarEmprestimo(int associadoId, string livroTitulo, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            // Buscar o associado
            var associado = BancoDados.Associado.FirstOrDefault(a => a.Id == associadoId);
            if (associado == null) return "Associado não encontrado.";

            // Verificar se o associado tem multa pendente
            if (associado.Multa > 0)
            {
                return "Associado possui multa pendente. Pague a multa antes de criar um novo empréstimo.";
            }

            // Verificar se o livro está disponível
            var livro = BancoDados.livros.FirstOrDefault(l => l.Titulo == livroTitulo);
            if (livro == null || livro.Status == "Emprestado")
            {
                return "Livro indisponível para empréstimo.";
            }

            // Criar o novo empréstimo
            var emprestimo = new Emprestimos
            {
                AssociadoId = associadoId,
                LivroTitulo = livroTitulo,
                DataEmprestimo = dataEmprestimo,
                DateDevolucao = dataDevolucao,
                Livros = new List<Livro> { livro },
                Status = "Emprestado"
            };

            // Adicionar o empréstimo no banco de dados
            BancoDados.Emprestimos.Add(emprestimo);

            // Atualizar o status do livro para "Emprestado"
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
        public static List<DateTime> ObterFeriados()
        {
            return new List<DateTime>
            {
                new DateTime(DateTime.Now.Year, 1, 1),  // Ano Novo
                new DateTime(DateTime.Now.Year, 4, 21), // Tiradentes
                new DateTime(DateTime.Now.Year, 5, 1),  // Dia do Trabalho
                new DateTime(DateTime.Now.Year, 9, 7),  // Independência do Brasil
                new DateTime(DateTime.Now.Year, 10, 12), // Nossa Senhora Aparecida
                new DateTime(DateTime.Now.Year, 11, 2),  // Finados
                new DateTime(DateTime.Now.Year, 11, 15), // Proclamação da República
                new DateTime(DateTime.Now.Year, 12, 25), // Natal
            };
        }

        public static void AtualizarEmprestimo(Emprestimos emprestimo)
        {
            var emprestimoExistente = BancoDados.Emprestimos.FirstOrDefault(e => e.Id == emprestimo.Id);
            if (emprestimoExistente != null)
            {
                emprestimoExistente.Multa = emprestimo.Multa;  // Atualiza a multa para 0
            }
        }
    }
}
     
    

