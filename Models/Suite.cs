using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_hospedagem.Models
{
    public class Suite
    {
        //Atributos
        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;

        //Getters e Setters
        public string TipoSuite
        {
            get { return _tipoSuite; }
            set { _tipoSuite = value; }
        }
        public int Capacidade
        {
            get { return _capacidade; }
            set { _capacidade = value; }
        }
        public decimal ValorDiaria
        {
            get { return _valorDiaria; }
            set { _valorDiaria = value; }
        }

        //Construtor

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            _tipoSuite = tipoSuite;
            _capacidade = capacidade;
            _valorDiaria = valorDiaria;
        }
    }
}