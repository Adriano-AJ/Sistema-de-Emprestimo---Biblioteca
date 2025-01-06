using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo___Biblioteca
{
    internal class BancoDados
    {
        public static List<Livro> livros = new List<Livro>();
        public static List<Associados> Associado = new List<Associados>();
        public static List<Emprestimos> Emprestimos = new List<Emprestimos>();

        // Método para atualizar o associado
        public static void AtualizarAssociado(Associados associado)
        {
            // Encontra o associado com o mesmo CPF
            var associadoExistente = BancoDados.Associado.FirstOrDefault(a => a.CPF == associado.CPF);
            if (associadoExistente != null)
            {
                // Atualiza os dados do associado, incluindo a multa zerada
                associadoExistente.Multa = associado.Multa;
                // Aqui, você pode atualizar outros dados do associado, se necessário
            }
        }

        public static void AtualizarEmprestimo(Emprestimos emprestimo)
        {
            var emprestimoExistente = BancoDados.Emprestimos.FirstOrDefault(e => e.Id == emprestimo.Id);
            if (emprestimoExistente != null)
            {
                // Atualizar a multa do empréstimo
                emprestimoExistente.Multa = emprestimo.Multa;
                // Aqui você pode adicionar mais propriedades, caso queira atualizar outros dados do empréstimo
            }
        }
    }

}







