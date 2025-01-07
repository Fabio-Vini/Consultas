using System.Collections.Generic;
using System;

public class Consulta
{
    private int _id;
    private DateTime _dataHora;
    private String _status;
    private int _duracaoEmHoras;
    private int _prontuarioPaciente;
    private int _crmMedico;
    private double _valor;

    public Consulta(DateTime dataHoraConsulta, int prontuarioPaciente, int crmMedico, double valor, List<Consulta> consultasMarcadas)
    {
        Status = "pendente";
        DuracaoEmHoras = 1;
        DataHora = dataHoraConsulta;
        Id = GerarIdAleatório(consultasMarcadas);
        ProntuarioMedico = prontuarioPaciente;
        CrmMedico = crmMedico;
        Valor = valor;
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
        private set { _duracaoEmHoras = value; }
    }

    public int ProntuarioMedico
    {
        get { return _prontuarioPaciente; }
        private set { _prontuarioPaciente = value; }
    }

    public int CrmMedico
    {
        get { return _crmMedico; }
        private set { _crmMedico = value; }
    }

    public double Valor
    {
        get { return _valor; }
        private set { _valor = value; }
    }

    public void CancelarConsulta()
    {
        this.Status = "cancelada";
    }

    public void AgendarConsulta()
    {
        Status = "marcada";
    }

    public void ImprimirDadosConsulta()
    {
        // Código de impressão
    }

    private int GerarIdAleatório(List<Consulta> consultasMarcadas)
    {
        Random random = new Random();
        int id = random.Next();
        if (consultasMarcadas.Count > 0)
        {
            foreach (var consulta in consultasMarcadas)
            {
                if (consulta.Id == id)
                {
                    return GerarIdAleatório(consultasMarcadas);
                }
            }
        }
        return id;
    }
}