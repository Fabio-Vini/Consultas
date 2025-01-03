using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas_Médicas
{
    public class Consulta
    {
        private int _id;
        private DateTime _dataHora;
        private String _status;
        private int _duracaoEmHoras;
        private int _prontuarioPaciente;
        private int _crmMedico;

        public Consulta(DateTime dataHoraConsulta, int prontuarioPaciente, int crmMedico, List<Consulta> consultasMarcadas)
        {
            Status = "pendente";
            DuracaoEmHoras = 1;
            DataHora = dataHoraConsulta;
            Id = GerarIdAleatório(consultasMarcadas);
            ProntuarioMedico = prontuarioPaciente;
            CrmMedico = crmMedico;
        }

        public int Id
        {
            get { return _id; }

            private set { _id = value; }
        }
        public DateTime DataHora
        {
            get { return _dataHora; }

            private set { _dataHora = value; }
        }
        public String Status
        {
            get { return _status; }

            private set { _status = value; }
        }
        public int DuracaoEmHoras
        {
            get { return _duracaoEmHoras; }

            private set { _duracaoEmHoras = value;}
        }

        public int ProntuarioMedico
        {
            get { return _prontuarioPaciente; }

            private set { _prontuarioPaciente = value; }
        }

        public int CrmMedico
        {
            get { return _crmMedico;  }
            private set { _crmMedico = value; }
        }

        public void CancelarConsulta(Paciente paciente)
        {

        }


        public void AgendarConsulta()
        {
            Status = "marcada";
        }
        public void CancelarConsulta()
        {
            //código
        }
        public void ImprimirDadosConsulta()
        {
            //código
        }

        private int GerarIdAleatório(List<Consulta> consultasMarcadas)
        {
            Random radom = new Random();
            int id = radom.Next();
            if (consultasMarcadas.Count > 0)
            {
                foreach (var consulta in consultasMarcadas)
                {
                    if (consulta.Id == id)
                    {
                        GerarIdAleatório(consultasMarcadas);
                    }
                }
            }
            return id;
        }
    }
}
