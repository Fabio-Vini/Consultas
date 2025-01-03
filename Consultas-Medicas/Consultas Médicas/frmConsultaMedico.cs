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
    public partial class frmConsultaMedico : Form
    {
        List<Medico> medicos;
        List<String> especialidadeMedico;

        frmCadastroMedico frmCadastroMedicoObj;

        public frmConsultaMedico(List<Medico> medicos, List<String> especialidadeMedico)
        {
            InitializeComponent();
            this.medicos = medicos;
            this.especialidadeMedico = especialidadeMedico;

            foreach (var medico in medicos)
            {
                ListViewItem item = new ListViewItem(medico.Nome);
                item.SubItems.Add(medico.Crm.ToString());
                item.SubItems.Add(medico.Especialidade);
                item.SubItems.Add(medico.ValorHora.ToString());
                lvwConsultaMedico.Items.Add(item);
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
            if (lvwConsultaMedico.SelectedItems.Count > 0)
            {
                string crmSelecionado = lvwConsultaMedico.SelectedItems[0].SubItems[1].Text;
                Medico medicoSelecionado = medicos.Single(x => x.Crm.ToString() == crmSelecionado);
                foreach (var horario in medicoSelecionado.Disponibilidade)
                {
                    lvwHorariosDisponiveisMedico.Items.Add(new ListViewItem(horario.ToString()));
                }
            }
        }

        private void btnAdicionarData_Click(object sender, EventArgs e)
        {
            DateTime data;
            data = dtpDataDisponibilidade.Value.Date.Add(new TimeSpan(dtpHoraDisponibilidade.Value.Hour, 0, 0));
            medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Disponibilidade.Add(data);
            ListViewItem item = new ListViewItem(Convert.ToString(data));
            lvwHorariosDisponiveisMedico.Items.Add(item);
        }

        private void btnRemoverData_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwHorariosDisponiveisMedico.Items)
            {
                if (item.Selected)
                {
                    lvwHorariosDisponiveisMedico.Items.Remove(item);

                    DateTime removerHora = medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Disponibilidade.Single(x => x.Date == Convert.ToDateTime(item.SubItems[0].Text).Date && x.Hour == Convert.ToDateTime(item.SubItems[0].Text).Hour);
                    medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Disponibilidade.Remove(removerHora);
                    MessageBox.Show(medicos.Single(x => x.Crm == Convert.ToDouble(lvwConsultaMedico.SelectedItems[0].SubItems[1].Text)).Disponibilidade.Count.ToString());
                }
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
                foreach (ListViewItem item in lvwConsultaMedico.SelectedItems)
                {
                    double crm = Convert.ToDouble(item.SubItems[1].Text);
                    lvwConsultaMedico.Items.Remove(item);
                    var medicoRemover = medicos.SingleOrDefault(x => x.Crm == crm);
                    if (medicoRemover != null)
                    {
                        medicos.Remove(medicoRemover);
                    }
                }
            }
        }
    }
}
