using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Consultas_Médicas
{
    public partial class frmConsultaMedico : Form
    {
        List<Medico> medicos;
        List<String> especialidadeMedico;
        List<Paciente> pacientes;

        frmCadastroMedico frmCadastroMedicoObj;
        frmAtualizarMedico frmAtualizarMedicoObj;

        public frmConsultaMedico(List<Medico> medicos, List<String> especialidadeMedico, List<Paciente> pacientes)
        {
            InitializeComponent();
            this.medicos = medicos;
            this.especialidadeMedico = especialidadeMedico;
            this.pacientes = pacientes;

            foreach (var medico in medicos)
            {
                ListViewItem item = new ListViewItem(medico.Nome);
                item.SubItems.Add(medico.Crm.ToString());
                item.SubItems.Add(medico.Especialidade);
                item.SubItems.Add(medico.ValorHora.ToString());
                lvwConsultaMedico.Items.Add(item);
            }
            foreach (var especialidade in especialidadeMedico)
            {
                cbEspecialidadeMedico.Items.Add(especialidade);
            }
        }

        private void cbEspecialidadeMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwConsultaMedico.Items.Clear();
            lvwHorariosDisponiveisMedico.Items.Clear();
            foreach (var medico in medicos)
            {
                if (medico.Especialidade == cbEspecialidadeMedico.Text)
                {
                    ListViewItem item = new ListViewItem(medico.Nome);
                    item.SubItems.Add(medico.Crm.ToString());
                    item.SubItems.Add(medico.Especialidade);
                    item.SubItems.Add(medico.ValorHora.ToString());
                    lvwConsultaMedico.Items.Add(item);
                }
            }
        }

        private void dtpFiltrarDataDisponibilidade_ValueChanged(object sender, EventArgs e)
        {
            lvwHorariosDisponiveisMedico.Items.Clear();
            string crmSelecionado = lvwConsultaMedico.SelectedItems[0].SubItems[1].Text;
            Medico medicoSelecionado = medicos.Single(x => x.Crm.ToString() == crmSelecionado);
            foreach (var horario in medicoSelecionado.Disponibilidade)
            {
                if (horario.Date == dtpFiltrarDataDisponibilidade.Value.Date)
                {
                    lvwHorariosDisponiveisMedico.Items.Add(new ListViewItem(horario.ToString()));
                }
            }
        }

        private void lvwConsultaMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwHorariosDisponiveisMedico.Items.Clear();
            lvwConsultasMarcadas.Items.Clear();
            if (lvwConsultaMedico.SelectedItems.Count > 0)
            {
                string crmSelecionado = lvwConsultaMedico.SelectedItems[0].SubItems[1].Text;
                Medico medicoSelecionado = medicos.Single(x => x.Crm.ToString() == crmSelecionado);
                foreach (var horario in medicoSelecionado.Disponibilidade)
                {
                    lvwHorariosDisponiveisMedico.Items.Add(new ListViewItem(horario.ToString()));
                }

                // Listar consultas dos pacientes do médico selecionado
                foreach (var consulta in medicoSelecionado.Consultas)
                {
                    if (consulta.Status != "cancelada")
                    {
                        var paciente = pacientes.SingleOrDefault(p => p.Prontuario == consulta.ProntuarioMedico);
                        if (paciente != null)
                        {
                            ListViewItem consultaItem = new ListViewItem(paciente.Nome);
                            consultaItem.SubItems.Add(paciente.Prontuario.ToString());
                            consultaItem.SubItems.Add(paciente.Cpf);
                            consultaItem.SubItems.Add(paciente.Sexo);
                            consultaItem.SubItems.Add(consulta.DataHora.ToString());
                            consultaItem.SubItems.Add(paciente.Logradouro);
                            lvwConsultasMarcadas.Items.Add(consultaItem);
                        }
                    }
                }
            }
        }

        private void btnAdicionarData_Click(object sender, EventArgs e)
        {
            if (lvwConsultaMedico.SelectedItems.Count > 0)
            {
                DateTime data;
                data = dtpDataDisponibilidade.Value.Date.Add(new TimeSpan(dtpHoraDisponibilidade.Value.Hour, 0, 0));
                bool consultaMarcada = false;

                foreach (var consulta in medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Consultas)
                {
                    if (data == consulta.DataHora)
                    {
                        consultaMarcada = true;
                    }
                }
                if (!medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Disponibilidade.Contains(data) && consultaMarcada == false)
                {
                    medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Disponibilidade.Add(data);
                    ListViewItem item = new ListViewItem(Convert.ToString(data));
                    lvwHorariosDisponiveisMedico.Items.Add(item);
                    dtpHoraDisponibilidade.Value += new TimeSpan(1, 0, 0);
                    MessageBox.Show("Horário Adicionado!", "Sucesso!");
                }
                else if (consultaMarcada == true)
                {
                    MessageBox.Show("Não é possivel cadastrar um horário que já possui consulta marcada!", "Erro de Cadastro");
                }
                else if (medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Disponibilidade.Contains(data))
                {
                    MessageBox.Show("Não é possível cadastrar dois horários iguais!", "Erro de Cadastro");
                }
            }
            else
            {
                MessageBox.Show("Selecione um médico antes de adicionar um horário!", "Erro");
            }
        }

        private void btnRemoverData_Click(object sender, EventArgs e)
        {
            if (lvwConsultaMedico.SelectedItems.Count > 0)
            {
                if (lvwHorariosDisponiveisMedico.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in lvwHorariosDisponiveisMedico.Items)
                    {
                        if (item.Selected)
                        {
                            lvwHorariosDisponiveisMedico.Items.Remove(item);

                            DateTime removerHora = medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Disponibilidade.Single(x => x.Date == Convert.ToDateTime(item.SubItems[0].Text).Date && x.Hour == Convert.ToDateTime(item.SubItems[0].Text).Hour);
                            medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Disponibilidade.Remove(removerHora);
                            MessageBox.Show("Horário Removido!", "Sucesso!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um horário antes de remover!", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Selecione um médico antes de remover um horário!", "Erro");
            }
        }

        private void btnAdicionarMedico_Click(object sender, EventArgs e)
        {
            Form frmConsultasMedicas = this.MdiParent;
            if (frmCadastroMedicoObj == null || frmCadastroMedicoObj.IsDisposed)
            {
                frmCadastroMedicoObj = new frmCadastroMedico(medicos, especialidadeMedico);
                frmCadastroMedicoObj.MdiParent = frmConsultasMedicas;
                frmCadastroMedicoObj.Show();
            }
            else
            {
                frmCadastroMedicoObj.Activate();

            }
        }

        private void btnRemoverMedico_Click(object sender, EventArgs e)
        {
            if (lvwConsultaMedico.SelectedItems.Count > 0) // Verifica se há itens selecionados
            {
                DialogResult resultadoRemoverMedico = MessageBox.Show("Tem certeza que quer remover o Médico?", "Tem certeza?", MessageBoxButtons.YesNo);
                if (resultadoRemoverMedico == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lvwConsultaMedico.SelectedItems)
                    {
                        double crm = Convert.ToDouble(item.SubItems[1].Text);
                        var medicoRemover = medicos.Single(x => x.Crm == crm);
                        bool removerMedico = true;
                        if (medicoRemover.Consultas.Count > 0)
                        {
                            DialogResult resultadoRemoverConsulta = MessageBox.Show("Remover esse médico irá remover todas as consultas marcadas. Tem certeza?", "Tem certeza?", MessageBoxButtons.YesNo);
                            if (resultadoRemoverConsulta == DialogResult.Yes)
                            {
                                List<Consulta> removerConsulta = new List<Consulta>();
                                foreach (var consulta in medicoRemover.Consultas)
                                {
                                    removerConsulta.Add(consulta);
                                }
                                foreach (var consulta in removerConsulta)
                                {
                                    medicoRemover.Consultas.Remove(consulta);
                                }
                                lvwConsultaMedico.Items.Remove(item);
                                medicos.Remove(medicoRemover);
                                MessageBox.Show("Médico removido!", "Sucesso!");
                                return;
                            }
                            else if (resultadoRemoverConsulta == DialogResult.No)
                            {
                                removerMedico = false;
                            }
                        }
                        else if (medicoRemover != null && removerMedico == true)
                        {
                            lvwConsultaMedico.Items.Remove(item);
                            medicos.Remove(medicoRemover);
                            MessageBox.Show("Médico removido!", "Sucesso!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um médico antes de remover!", "Erro");
            }
        }

        private void btnAtualizarMedico_Click(object sender, EventArgs e)
        {
            if (lvwConsultaMedico.SelectedItems.Count > 0) // Verifica se há itens selecionados
            {
                int crmMedico = Convert.ToInt32(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text);
                Medico medicoSelecionado = medicos.Single(x => x.Crm == crmMedico);
                Form frmAtualizarMedico = this.MdiParent;
                if (frmAtualizarMedicoObj == null || frmAtualizarMedicoObj.IsDisposed)
                {
                    frmAtualizarMedicoObj = new frmAtualizarMedico(medicos, medicoSelecionado, especialidadeMedico);
                    frmAtualizarMedicoObj.MdiParent = frmAtualizarMedico;
                    frmAtualizarMedicoObj.Show();
                }
                else
                {
                    frmAtualizarMedicoObj.Activate();
                }
            }
            else
            {
                MessageBox.Show("Selecione um médico antes de atualizar seu cadastro!", "Erro");
            }
        }

        private void btnCancelarConsultasMedico_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwConsultasMarcadas.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in lvwConsultasMarcadas.SelectedItems)
                    {
                        int prontuarioPaciente = Convert.ToInt32(item.SubItems[1].Text);
                        DateTime dataHoraConsulta = DateTime.Parse(item.SubItems[4].Text);

                        var paciente = pacientes.SingleOrDefault(p => p.Prontuario == prontuarioPaciente);
                        if (paciente != null)
                        {
                            var consulta = paciente.Consultas.SingleOrDefault(c => c.DataHora == dataHoraConsulta);
                            if (consulta != null)
                            {
                                consulta.CancelarConsultaComAtualizacao(pacientes, medicos);
                                lvwConsultasMarcadas.Items.Remove(item);
                                paciente.AdicionarSaldo(consulta.Valor);
                                MessageBox.Show("Consulta cancelada e saldo reembolsado com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Consulta não encontrada.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Paciente não encontrado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma consulta para cancelar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar consultas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}