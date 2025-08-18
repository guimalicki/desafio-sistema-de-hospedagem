using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_hospedagem.Models
{
    public class Pessoa
    {
        //Atributos
        private string _nome;
        private string _sobrenome;


        //Getters e Setters
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }

        //Construtor
        public Pessoa(string nome, string sobrenome)
        {
            _nome = nome;
            _sobrenome = sobrenome;
        }
    }
}