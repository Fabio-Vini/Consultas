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
    public partial class frmConsultaEspecialidades : Form
    {
        List<String> especialidadeMedico;
        public frmConsultaEspecialidades(List<String> especialidadeMedico)
        {
            InitializeComponent();
            this.especialidadeMedico = especialidadeMedico;
            foreach (var especialidade in especialidadeMedico)
            {
                ListViewItem item = new ListViewItem(especialidade);
                lvwExibirEspecialidades.Items.Add(item);
            }
        }

        private void btnAdicionarEspecialidade_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(especialidadeMedico.Count.ToString());
            if (!String.IsNullOrEmpty(txtNovaEspecialidade.Text))
            {
                especialidadeMedico.Add(txtNovaEspecialidade.Text);
                lvwExibirEspecialidades.Items.Clear();
                foreach (var especialidade in especialidadeMedico)
                {
                    ListViewItem item2 = new ListViewItem(especialidade);
                    lvwExibirEspecialidades.Items.Add(item2);
                }
            }
        }

        private void btnRemoverEspecialidade_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwExibirEspecialidades.Items)
            {
                if (item.Selected)
                {
                    MessageBox.Show(especialidadeMedico.Count.ToString());
                    lvwExibirEspecialidades.Items.Remove(item);
                    //String removerEspecialidade = especialidadeMedico.Single(x => x == item.Text);
                    especialidadeMedico.Remove(item.Text);
                    MessageBox.Show(especialidadeMedico.Count.ToString());
                }
            }
        }

        private void lvwExibirEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}