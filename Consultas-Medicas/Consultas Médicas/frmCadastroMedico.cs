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
    public partial class frmCadastroMedico : Form
    {
        List<Medico> medicoLista;
        List<DateTime> disponibilidadeLista  = new List<DateTime>();
        List<String> especialidadeMedico;
        public frmCadastroMedico(List<Medico> medico, List<String> especialidadeMedico)
        {
            InitializeComponent();
            this.medicoLista = medico;
            foreach(var especialidade in especialidadeMedico)
            {
                cbCadastroEspecialidadeMedico.Items.Add(especialidade);
            }
        }

        private void btnCadastroMedico_Click(object sender, EventArgs e)
        {
            medicoLista.Add(new Medico(txtCadastroNomeMedico.Text, Convert.ToInt32(txtCadastroCrmMedico.Text), cbCadastroEspecialidadeMedico.Text, Convert.ToDouble(txtCadastroValorHoraMedico.Text), new List<DateTime> (disponibilidadeLista)));
            MessageBox.Show(medicoLista[0].Disponibilidade.Count.ToString());
        }
        private void btnAdicionarData_Click(object sender, EventArgs e)
        {
            DateTime data;
            data = dtpDataDisponibilidade.Value.Date.Add(new TimeSpan(dtpHoraDisponibilidade.Value.Hour, 0, 0));
            disponibilidadeLista.Add(data);
            ListViewItem item = new ListViewItem(Convert.ToString(data));
            lvwDatasDisponibilidade.Items.Add(item);
        }

        private void btnRemoverData_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvwDatasDisponibilidade.Items)
            {
                if(item.Selected)
                {
                    lvwDatasDisponibilidade.Items.Remove(item);
                    DateTime removerHora = disponibilidadeLista.Single(x => x.Date == Convert.ToDateTime(item.SubItems[0].Text).Date&& x.Hour == Convert.ToDateTime(item.SubItems[0].Text).Hour);
                    disponibilidadeLista.Remove(removerHora);
                    MessageBox.Show(disponibilidadeLista.Count.ToString());
                }
            }
        }
    }
}
