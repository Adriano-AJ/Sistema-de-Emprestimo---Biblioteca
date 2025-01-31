﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo___Biblioteca
{
    internal class Associados
    {   
        //Atributos
        private static int _idCounter = 0;
        private int _id;
        private string _cpf;
        private string _nome;
        private string _sexo;
        private string _logradouro;
        private string _estado;
        private string _cidade;
        private string _pais;
        private double _multa;

        //Propriedades

        public int Id { get { return _id; } }
        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("CPF inválido.");
                _cpf = value;
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nome não pode ser vazio.");
                _nome = value;
            }
        }

        public string Sexo
        {
            get { return _sexo; }
            set
            {
                if (value != "Masculino" && value != "Feminino")
                    throw new ArgumentException("Sexo deve ser 'Masculino' ou 'Feminino'.");
                _sexo = value;
            }
        }

        public string Logradouro
        {
            get { return _logradouro; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Logradouro não pode ser vazio.");
                _logradouro = value;
            }
        }

        public string Estado
        {
            get { return _estado; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Estado não pode ser vazio.");
                _estado = value;
            }
        }

        public string Cidade
        {
            get { return _cidade; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Cidade não pode ser vazia.");
                _cidade = value;
            }
        }

        public string Pais
        {
            get { return _pais; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("País não pode ser vazio.");
                _pais = value;
            }
        }

        public double Multa
        {
            get { return _multa; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Multa não pode ser negativa.");
                _multa = value;
            }
        }

        public static Associados CriarAssociado(string nome, string cpf, string sexo, string logradouro, string cidade, string estado, string pais)
        {
            Associados associado = new Associados();
            associado.Nome = nome;
            associado.CPF = cpf;
            associado.Sexo = sexo;
            associado.Logradouro = logradouro;
            associado.Cidade = cidade;
            associado.Estado = estado;
            associado.Pais = pais;

            associado._id = ++_idCounter;

            return associado;

        }



        public bool QuitarMultas(double valorPago)
        {
            // Verifica se o valor pago é suficiente para quitar a multa
            if (valorPago >= Multa)
            {
                Multa = 0; // Zera a multa
                return true;
            }
            return false; // Caso o valor pago seja insuficiente
        }

    }
}

