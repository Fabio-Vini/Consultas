using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas_Médicas
{
    public partial class frmConsultarDisponibilidade : Form
    {
        //Formulários
        frmCadastroPaciente frmCadastroPacienteObj;
        frmAgendarConsulta frmAgendarConsultaObj;

        //Listas
        List<Medico> medicoLista;
        List<String> especialidadeMedico;
        List<Paciente> pacienteLista;
        List<Consulta> consultasMarcadas;
        public frmConsultarDisponibilidade(List<Medico> medicoLista, List<Paciente> pacienteLista, List<String> especialidadeMedico, List<Consulta> consultasMarcadas)
        {
            InitializeComponent();
            this.medicoLista = medicoLista;
            this.especialidadeMedico = especialidadeMedico;
            this.pacienteLista = pacienteLista;
            this.consultasMarcadas = consultasMarcadas;

            foreach (var medico in medicoLista)
            {
                ListViewItem item = new ListViewItem(medico.Nome);
                item.SubItems.Add(medico.Crm.ToString());
                item.SubItems.Add(medico.Especialidade);
                item.SubItems.Add(medico.ValorHora.ToString());
                lvwMedicos.Items.Add(item);
            }

            foreach (var especialidade in especialidadeMedico)
            {
                cbEspecialidadeMedico.Items.Add(especialidade);
            }
        }

        private void lvwMedicos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lvwHorariosDisponiveisMedico.Items.Clear();
            if (lvwMedicos.SelectedItems.Count > 0)
            {
                string crmSelecionado = lvwMedicos.SelectedItems[0].SubItems[1].Text;
                Medico medicoSelecionado = medicoLista.SingleOrDefault(x => x.Crm.ToString() == crmSelecionado);
                if (medicoSelecionado != null)
                {
                    foreach (var horario in medicoSelecionado.Disponibilidade)
                    {
                        lvwHorariosDisponiveisMedico.Items.Add(new ListViewItem(horario.ToString()));
                    }
                }
                else
                {
                    MessageBox.Show("Médico não encontrado.");
                }
            }
        }

        /*private void lvwMedicos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lvwHorariosDisponiveisMedico.Items.Clear();
            if (lvwMedicos.SelectedItems.Count > 0)
            {
                string crmSelecionado = lvwMedicos.SelectedItems[0].SubItems[1].Text;
                Medico medicoSelecionado = medicoLista.Single(x => x.Crm.ToString() == crmSelecionado);
                foreach (var horario in medicoSelecionado.Disponibilidade)
                {
                    lvwHorariosDisponiveisMedico.Items.Add(new ListViewItem(horario.ToString()));
                }
            }
        }*/

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

        /*private void cbEspecialidadeMedico_SelectedIndexChanged(object sender, EventArgs e)
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
        }*/

        private void dtpFiltrarDataDisponibilidade_ValueChanged(object sender, EventArgs e)
        {
            lvwHorariosDisponiveisMedico.Items.Clear();
            if (lvwMedicos.SelectedItems.Count > 0)
            {
                string crmSelecionado = lvwMedicos.SelectedItems[0].SubItems[1].Text;
                Medico medicoSelecionado = medicoLista.SingleOrDefault(x => x.Crm.ToString() == crmSelecionado);
                if (medicoSelecionado != null)
                {
                    foreach (var horario in medicoSelecionado.Disponibilidade)
                    {
                        if (horario.Date == dtpFiltrarDataDisponibilidade.Value.Date)
                        {
                            lvwHorariosDisponiveisMedico.Items.Add(new ListViewItem(horario.ToString()));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Médico não encontrado.");
                }
            }
        }

        /*private void dtpFiltrarDataDisponibilidade_ValueChanged(object sender, EventArgs e)
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
        }*/

        private void lblAgendarConsulta_Click(object sender, EventArgs e)
        {
            if (lvwMedicos.SelectedItems.Count > 0 && lvwHorariosDisponiveisMedico.SelectedItems.Count > 0)
            {
                string crmSelecionado = lvwMedicos.SelectedItems[0].SubItems[1].Text;
                Medico medicoSelecionado = medicoLista.SingleOrDefault(x => x.Crm.ToString() == crmSelecionado);
                if (medicoSelecionado != null)
                {
                    string dataSelecionada = lvwHorariosDisponiveisMedico.SelectedItems[0].Text;
                    DateTime horarioSelecionado = medicoSelecionado.Disponibilidade.SingleOrDefault(x => x.ToString() == dataSelecionada);
                    if (horarioSelecionado != default(DateTime))
                    {
                        DialogResult resultadoDialogo = MessageBox.Show("O Paciente já está cadastrado?", "Agendar Consulta", MessageBoxButtons.YesNoCancel);
                        Form frmConsultasMedicas = this.MdiParent;
                        if (resultadoDialogo == DialogResult.Yes)
                        {
                            if (frmAgendarConsultaObj == null || frmAgendarConsultaObj.IsDisposed)
                            {
                                frmAgendarConsultaObj = new frmAgendarConsulta(pacienteLista, medicoLista, especialidadeMedico, medicoSelecionado, horarioSelecionado, consultasMarcadas);
                                frmAgendarConsultaObj.MdiParent = frmConsultasMedicas;
                                frmAgendarConsultaObj.Show();
                            }
                            else
                            {
                                frmAgendarConsultaObj.Activate();
                            }
                        }
                        else if (resultadoDialogo == DialogResult.No)
                        {
                            if (frmCadastroPacienteObj == null || frmCadastroPacienteObj.IsDisposed)
                            {
                                frmCadastroPacienteObj = new frmCadastroPaciente(pacienteLista, medicoLista, especialidadeMedico, medicoSelecionado, horarioSelecionado, consultasMarcadas);
                                frmCadastroPacienteObj.MdiParent = frmConsultasMedicas;
                                frmCadastroPacienteObj.Show();
                            }
                            else
                            {
                                frmCadastroPacienteObj.Activate();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Horário não encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Médico não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um médico e um horário.");
            }
        }

        /* private void lblAgendarConsulta_Click(object sender, EventArgs e)
         {
             if (lvwMedicos.SelectedItems.Count > 0)
             {
                 string crmSelecionado = lvwMedicos.SelectedItems[0].SubItems[1].Text;
                 Medico medicoSelecionado = medicoLista.Single(x => x.Crm.ToString() == crmSelecionado);
                 string dataSelecionada = lvwHorariosDisponiveisMedico.SelectedItems[0].Text;
                 DateTime horarioSelecionado = medicoSelecionado.Disponibilidade.Single(x => x.ToString() == dataSelecionada);
                 //foreach (var horario in medicoSelecionado.Disponibilidade)
                 //{
                 //    lvwHorariosDisponiveisMedico.Items.Add(new ListViewItem(horario.ToString()));
                 //}

                 DialogResult resultadoDialogo = MessageBox.Show("O Paciente já está cadastrado?", "Agendar Consuta", MessageBoxButtons.YesNoCancel);
                 Form frmConsultasMedicas = this.MdiParent;
                 if (resultadoDialogo == DialogResult.Yes)
                 {
                     if (frmAgendarConsultaObj == null || frmAgendarConsultaObj.IsDisposed)
                     {
                         frmAgendarConsultaObj = new frmAgendarConsulta(pacienteLista, medicoLista, especialidadeMedico, medicoSelecionado, horarioSelecionado, consultasMarcadas);
                         frmAgendarConsultaObj.MdiParent = frmConsultasMedicas;
                         frmAgendarConsultaObj.Show();
                     }
                     else
                     {
                         frmAgendarConsultaObj.Activate();
                     }
                 }
                 else if (resultadoDialogo == DialogResult.No)
                 {
                     if (frmCadastroPacienteObj == null || frmCadastroPacienteObj.IsDisposed)
                     {
                         frmCadastroPacienteObj = new frmCadastroPaciente(pacienteLista, medicoLista, especialidadeMedico, medicoSelecionado, horarioSelecionado, consultasMarcadas);
                         frmCadastroPacienteObj.MdiParent = frmConsultasMedicas;
                         frmCadastroPacienteObj.Show();
                     }
                     else
                     {
                         frmCadastroPacienteObj.Activate();
                     }
                 }
             }
         }*/
    }
}