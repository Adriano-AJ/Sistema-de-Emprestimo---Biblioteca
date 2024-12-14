using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo___Biblioteca
{
    internal class Livro
    {
        private static int _idCounter = 0;
        private int _id;
        private long _isbn;
        private string _titulo;
        private string _autor;
        private string _editora;

        public int Id { get { return _id; } }
        public long Isbn {
            get {  return _isbn; }
            set
            {
                if (value.ToString().Length == 13)
                {
                    _isbn = value;
                }
                else
                {
                    throw new ArgumentException("O código Isbn tem que ter 13 caracteres");
                }
            }
         }
        public string Titulo {
            get { return _titulo; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo titulo não pode ser vazio.");
                }
                else
                {
                    _titulo = value;
                }
            } 
        }
        public string Autor { 
            get { return _autor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo autor não pode ser vazio.");
                }
                else
                {
                    _autor = value;
                }

            }
        }
        public string Editora { 
            get { return _editora; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O campo editora não pode ser vazio.");
                }
                else
                {
                    _editora = value;
                }

            }
        }

        private Livro() { }
        public static Livro CriarLivro(string titulo, string autor, string editora, long isbn)
        {
            Livro livro = new Livro();
            livro.Titulo = titulo;
            livro.Autor = autor;
            livro.Editora = editora;
            livro.Isbn = isbn;

            livro._id = ++_idCounter;

            return livro;
           
        }
    }
}
