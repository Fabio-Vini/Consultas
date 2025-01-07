using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Médicas
{
    public class Medico
    {
        private string _nome;
        private int _crm;
        private string _especialidade;
        private List<DateTime> _disponibilidade = new List<DateTime>();
        private double _valorHora;
        private List<Consulta> _consultas = new List<Consulta>();

        //Adicionar Lista como parametro

        public Medico(string nome, int crm, string especialidade, double valorHora, List<DateTime> disponibilidade)
        {
            _nome = nome;
            _crm = crm;
            _especialidade = especialidade;
            _valorHora = valorHora;
            _disponibilidade = disponibilidade;
        }

        public String Nome
        {
            get { return _nome; }
        }

        public int Crm
        {
            get { return _crm; }
        }

        public string Especialidade
        {
            get { return _especialidade; }
        }

        public List<DateTime> Disponibilidade
        {
            get { return _disponibilidade; }
            set { _disponibilidade = value; }
        }
        public double ValorHora
        {
            get { return _valorHora; }
        }

        public List<Consulta> Consultas
        {
            get { return _consultas; }

            set { _consultas = value; }
        }
    }
}