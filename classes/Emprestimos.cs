using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo___Biblioteca
{
    internal class Emprestimos
    {
        private static int _idCounter = 0;
        private int _id;
        private DateTime _dataEmprestimo;
        private DateTime _dataDevolucao;
        private string _status;

        public int Id { get { return _id; } }

        public DateTime DateDevolucao { get { return _dataDevolucao; } set { } }

        public DateTime DataEmprestimo { get { return _dataEmprestimo; } set { } }

        public string Status { get { return _status; } set { _status = value; } }

        //Metodos

        private Emprestimos() { }

        public static Emprestimos CriarEmprestimo(DateTime dataEmprestimo, DateTime dataDevolucao, string status)
        {
            var emprestimo = new Emprestimos
            {
                _id = ++_idCounter,
                _dataEmprestimo = dataEmprestimo,
                _dataDevolucao = dataDevolucao,
                _status = status
            };

            return emprestimo;
        }
    }
}
