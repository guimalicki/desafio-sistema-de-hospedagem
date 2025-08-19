using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_hospedagem.Models
{
    public class Reserva
    {
        //Atributos
        private List<Pessoa> _hospedes = new List<Pessoa>();
        private Suite _suite;
        private int _diasReservados;

        //Getters e Setters
        //Não criamos setters para a lista de hóspedes, pois não queremos que ela seja modificada diretamente.
        public List<Pessoa> Hospedes
        {
            get { return _hospedes; }
        }
        public Suite Suite
        {
            get { return _suite; }
        }
        public int DiasReservados
        {
            get { return _diasReservados; }
            set { _diasReservados = value; }
        }

        //Construtor
        public Reserva(int diasReservados)
        {
            _diasReservados = diasReservados;
            _suite = new Suite("", 0, 0); //Suite inicial
        }

        //Métodos
        //Cadastro da suite
        public void CadastrarSuite(Suite suite)
        {
            _suite = suite;
        }

        //Cadastrar hóspedes
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //Verifica se o número de hóspedes não excede a capacidade da suíte
            if (hospedes.Count > _suite.Capacidade)
            {
                throw new Exception("Número de hóspedes excede a capacidade da suíte.");
            }
            else
            {
                //Adiciona os hóspedes à lista
                _hospedes.AddRange(hospedes);
            }
        }

        public int ObterQuantidadeHospedes()
        {
            //Retorna a quantidade de hóspedes cadastrados
            return _hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            return _suite.ValorDiaria * _diasReservados;
        }
    }
}