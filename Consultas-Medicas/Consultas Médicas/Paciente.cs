using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Médicas
{
    public class Paciente
    {
        private String _cpf;
        private int _prontuario;
        private String _nome;
        private String _sexo;
        private String _logradouro;
        private String _cidade;
        private String _estado;
        private String _pais;
        private double _saldo;
        private List<Consulta> _consultas = new List<Consulta>();

        public Paciente(string cpf, string nome, string sexo, string logradouro, string cidade, string estado, string pais, List<Paciente> pacienteLista)
        {
            _cpf = cpf;
            _nome = nome;
            _sexo = sexo;
            _logradouro = logradouro;
            _cidade = cidade;
            _estado = estado;
            _pais = pais;
            _prontuario = GerarProntuario(pacienteLista);
        }

        public String Cpf
        {
            get { return _cpf; }
        }

        public int Prontuario
        {
            get { return _prontuario; }
        }

        public string Nome
        {
            get { return _nome; }
        }

        public string Sexo
        {
            get { return _sexo; }
        }

        public string Logradouro
        {
            get { return _logradouro; }
        }

        public string Cidade
        {
            get { return _cidade; }
        }

        public string Estado
        {
            get { return _estado; }
        }

        public string Pais
        {
            get { return _pais; }
        }

        public double Saldo
        {
            get { return _saldo; }

            private set { _saldo = value; }
        }

        public List<Consulta> Consultas
        {
            get { return _consultas; }

            set { _consultas = value; }
        }

        public void AdicionarSaldo(double valorAdicionado)
        {
            Saldo += valorAdicionado; 
        }

        public void DescontarSaldo(double valorDescontado)
        {
            Saldo -= valorDescontado;
        }

        private int GerarProntuario(List<Paciente> pacienteLista)
        {
            Random random = new Random();
            int prontuario = random.Next();
            if(pacienteLista.Count > 0)
            {
                foreach (var paciente in pacienteLista)
                {
                    if (paciente.Prontuario == prontuario)
                    {
                        GerarProntuario(pacienteLista);
                    }
                }
            }
            return prontuario;
        }
    }
}
