using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas_Médicas
{
    public partial class frmAgendarConsulta : Form
    {
        List<Paciente> pacienteLista;
        List<Medico> medicoLista;
        List<String> especialidadeMedico;
        List<Consulta> consultasMarcadas;
        List<DateTime> horariosParaRemover = new List<DateTime>();

        Medico medicoSelecionado;
        DateTime horarioSelecionado;
        Paciente pacienteSelecionado;
        public frmAgendarConsulta(List<Paciente> pacienteLista, List<Medico> medicoLista, List<String> especialidadeMedico, Medico medicoSelecionado, DateTime horarioSelecionado, Paciente pacienteSelecionado, List<Consulta> consultasMarcadas)
        {
            InitializeComponent();
            this.pacienteLista = pacienteLista;
            this.medicoLista = medicoLista;
            this.especialidadeMedico = especialidadeMedico;
            this.consultasMarcadas = consultasMarcadas;

            this.medicoSelecionado = medicoSelecionado;
            this.horarioSelecionado = horarioSelecionado;
            this.pacienteSelecionado = pacienteSelecionado;


            //Listar Pacientes
            foreach (var paciente in pacienteLista)
            {
                ListViewItem item = new ListViewItem(paciente.Nome);
                item.SubItems.Add(paciente.Cpf);
                item.SubItems.Add(paciente.Prontuario.ToString());
                item.SubItems.Add(paciente.Sexo);
                item.SubItems.Add(paciente.Saldo.ToString());
                if (paciente == pacienteSelecionado)
                {
                    item.Selected = true;
                }
                lvwConsultaPaciente.Items.Add(item);
            }

            //Listar Medicos e Selecionar
            foreach (var medico in medicoLista)
            {
                ListViewItem item = new ListViewItem(medico.Nome);
                item.SubItems.Add(medico.Crm.ToString());
                item.SubItems.Add(medico.Especialidade);
                item.SubItems.Add(medico.ValorHora.ToString());
                if (medico == medicoSelecionado)
                {
                    item.Selected = true;
                }
                lvwMedicos.Items.Add(item);
            }

            if (lvwMedicos.SelectedItems.Count > 0)
            {
                foreach (var horario in medicoSelecionado.Disponibilidade)
                {
                    ListViewItem item = new ListViewItem(horario.ToString());
                    item.SubItems.Add(horario.ToString());
                    if (horario == horarioSelecionado)
                    {
                        item.Selected = true;
                    }
                    lvwHorariosDisponiveisMedico.Items.Add(item);
                }
            }

            //Listar Especialidades
            foreach (var especialidade in especialidadeMedico)
            {
                cbEspecialidadeMedico.Items.Add(especialidade);
            }


        }

        public frmAgendarConsulta(List<Paciente> pacienteLista, List<Medico> medicoLista, List<String> especialidadeMedico, Medico medicoSelecionado, DateTime horarioSelecionado, List<Consulta> consultasMarcadas)
        {
            InitializeComponent();
            this.pacienteLista = pacienteLista;
            this.medicoLista = medicoLista;
            this.especialidadeMedico = especialidadeMedico;
            this.consultasMarcadas = consultasMarcadas;

            this.medicoSelecionado = medicoSelecionado;
            this.horarioSelecionado = horarioSelecionado;

            //Listar Pacientes
            foreach (var paciente in pacienteLista)
            {
                ListViewItem item = new ListViewItem(paciente.Nome);
                item.SubItems.Add(paciente.Cpf);
                item.SubItems.Add(paciente.Prontuario.ToString());
                item.SubItems.Add(paciente.Sexo);
                item.SubItems.Add(paciente.Saldo.ToString());
                lvwConsultaPaciente.Items.Add(item);
            }

            //Listar Medicos e Selecionar
            foreach (var medico in medicoLista)
            {
                ListViewItem item = new ListViewItem(medico.Nome);
                item.SubItems.Add(medico.Crm.ToString());
                item.SubItems.Add(medico.Especialidade);
                item.SubItems.Add(medico.ValorHora.ToString());
                if (medico == medicoSelecionado)
                {
                    item.Selected = true;
                }
                lvwMedicos.Items.Add(item);
            }

            if (lvwMedicos.SelectedItems.Count > 0)
            {
                foreach (var horario in medicoSelecionado.Disponibilidade)
                {
                    ListViewItem item = new ListViewItem(horario.ToString());
                    if (horario == horarioSelecionado)
                    {
                        item.Selected = true;
                    }
                    lvwHorariosDisponiveisMedico.Items.Add(item);
                }
            }

            //Listar Especialidades
            foreach (var especialidade in especialidadeMedico)
            {
                cbEspecialidadeMedico.Items.Add(especialidade);
            }
        }

        private void lvwMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwHorariosDisponiveisMedico.Items.Clear();
            if (lvwMedicos.SelectedItems.Count > 0)
            {
                foreach (var horario in medicoSelecionado.Disponibilidade)
                {
                    ListViewItem item = new ListViewItem(horario.ToString());
                    if (horario == horarioSelecionado)
                    {
                        item.Selected = true;
                    }
                    lvwHorariosDisponiveisMedico.Items.Add(item);
                }
            }
        }

        private void cbEspecialidadeMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwMedicos.Items.Clear();
            lvwHorariosDisponiveisMedico.Items.Clear();
            foreach (var medico in medicoLista)
            {
                if (medico.Especialidade == cbEspecialidadeMedico.Text)
                {
                    ListViewItem item = new ListViewItem(medico.Nome);
                    item.SubItems.Add(medico.Crm.ToString());
                    item.SubItems.Add(medico.Especialidade);
                    item.SubItems.Add(medico.ValorHora.ToString());
                    lvwMedicos.Items.Add(item);
                }
            }
        }

        private void dtpFiltrarDataDisponibilidade_ValueChanged(object sender, EventArgs e)
        {
            lvwHorariosDisponiveisMedico.Items.Clear();
            string crmSelecionado = lvwMedicos.SelectedItems[0].SubItems[1].Text;
            Medico medicoSelecionado = medicoLista.Single(x => x.Crm.ToString() == crmSelecionado);
            foreach (var horario in medicoSelecionado.Disponibilidade)
            {
                if (horario.Date == dtpFiltrarDataDisponibilidade.Value.Date)
                {
                    lvwHorariosDisponiveisMedico.Items.Add(new ListViewItem(horario.ToString()));
                }
            }
        }

        private void txtFiltrarNomePaciente_TextChanged(object sender, EventArgs e)
        {
            lvwConsultaPaciente.Items.Clear();
            int tamanhoPesquisa = txtFiltrarNomePaciente.Text.Length;
            if (txtFiltrarNomePaciente.Text != "")
            {
                foreach (var paciente in pacienteLista)
                {
                    if (txtFiltrarNomePaciente.Text.ToLower() == paciente.Nome.Substring(0, tamanhoPesquisa).ToLower())
                    {
                        ListViewItem item = new ListViewItem(paciente.Nome);
                        item.SubItems.Add(paciente.Cpf.ToString());
                        item.SubItems.Add(paciente.Prontuario.ToString());
                        item.SubItems.Add(paciente.Sexo);
                        item.SubItems.Add(paciente.Saldo.ToString());
                        lvwConsultaPaciente.Items.Add(item);
                    }
                }
            }
            else if (txtFiltrarNomePaciente.Text == "")
            {
                foreach (var paciente in pacienteLista)
                {
                    ListViewItem item = new ListViewItem(paciente.Nome);
                    item.SubItems.Add(paciente.Cpf);
                    item.SubItems.Add(paciente.Prontuario.ToString());
                    item.SubItems.Add(paciente.Sexo);
                    item.SubItems.Add(paciente.Saldo.ToString());
                    lvwConsultaPaciente.Items.Add(item);
                }
            }
        }

        private void txtFiltrarCpfPaciente_TextChanged(object sender, EventArgs e)
        {
            lvwConsultaPaciente.Items.Clear();
            int tamanhoPesquisa = txtFiltrarCpfPaciente.Text.Length;
            if (txtFiltrarCpfPaciente.Text != "")
            {
                foreach (var paciente in pacienteLista)
                {
                    if (txtFiltrarCpfPaciente.Text.ToLower() == paciente.Cpf.Substring(0, tamanhoPesquisa).ToLower())
                    {
                        ListViewItem item = new ListViewItem(paciente.Nome);
                        item.SubItems.Add(paciente.Cpf.ToString());
                        item.SubItems.Add(paciente.Prontuario.ToString());
                        item.SubItems.Add(paciente.Sexo);
                        item.SubItems.Add(paciente.Saldo.ToString());
                        lvwConsultaPaciente.Items.Add(item);
                    }
                }
            }
            else if (txtFiltrarCpfPaciente.Text == "")
            {
                foreach (var paciente in pacienteLista)
                {
                    ListViewItem item = new ListViewItem(paciente.Nome);
                    item.SubItems.Add(paciente.Cpf);
                    item.SubItems.Add(paciente.Prontuario.ToString());
                    item.SubItems.Add(paciente.Sexo);
                    item.SubItems.Add(paciente.Saldo.ToString());
                    lvwConsultaPaciente.Items.Add(item);
                }
            }
        }

        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwConsultaPaciente.SelectedItems.Count > 0 && lvwConsultaPaciente.SelectedItems.Count > 0 && lvwHorariosDisponiveisMedico.SelectedItems.Count > 0)
                {
                    Paciente pacienteConsulta = pacienteLista.Single(x => x.Prontuario == Convert.ToInt32(lvwConsultaPaciente.SelectedItems[0].SubItems[2].Text));
                    Medico medicoConsulta = medicoLista.Single(x => x.Crm == Convert.ToInt32(lvwMedicos.SelectedItems[0].SubItems[1].Text));
                    Consulta novaConsulta = new Consulta(
     Convert.ToDateTime(lvwHorariosDisponiveisMedico.SelectedItems[0].Text),
     pacienteConsulta.Prontuario,
     medicoConsulta.Crm,
     consultasMarcadas
 );
                    foreach (var horario in medicoSelecionado.Disponibilidade)
                    {
                        if (horario == medicoSelecionado.Disponibilidade[medicoSelecionado.Disponibilidade.Count - 1] && horario != horarioSelecionado)
                        {
                            throw new Exception("Horário não disponível!");
                        }
                        else if (horario == horarioSelecionado)
                        {
                            if (pacienteConsulta.Saldo >= medicoConsulta.ValorHora)
                            {
                                pacienteConsulta.DescontarSaldo(medicoConsulta.ValorHora);
                                novaConsulta.AgendarConsulta();
                                pacienteConsulta.Consultas.Add(novaConsulta);
                                medicoConsulta.Consultas.Add(novaConsulta);
                                medicoConsulta.Disponibilidade = medicoConsulta.Disponibilidade.Where(h => h != novaConsulta.DataHora).ToList();
                                consultasMarcadas.Add(novaConsulta);
                                MessageBox.Show("Consulta marcada!");
                            }
                            else
                            {
                                throw new Exception($"O paciente necessita de R${medicoConsulta.ValorHora - pacienteConsulta.Saldo} para marcar a consulta!");
                            }
                            break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Selecione um Paciente, um Médico e um horário para marcar a consulta");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro");
            }
        }
    }
}
