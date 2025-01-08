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
    public partial class frmAtualizarMedico : Form
    {
        List<Medico> listaMedicos;
        Medico medico;
        List<String> especialidadeMedico;

        public frmAtualizarMedico(List<Medico> listaMedicos, Medico medico, List<String> especialidadeMedico)
        {
            InitializeComponent();
            this.listaMedicos = listaMedicos;
            this.medico = medico;
            this.especialidadeMedico = especialidadeMedico;

            foreach (var especialidade in especialidadeMedico)
            {
                cbCadastroEspecialidadeMedico.Items.Add(especialidade);
            }

            txtCadastroNomeMedico.Text = medico.Nome;
            txtCadastroCrmMedico.Text = medico.Crm.ToString();
            cbCadastroEspecialidadeMedico.SelectedItem = medico.Especialidade;
            txtCadastroValorHoraMedico.Text = medico.ValorHora.ToString();
        }

        private void btnAtualizarMedico_Click(object sender, EventArgs e)
        {
            listaMedicos.Single(x => x.Crm == medico.Crm).Nome = txtCadastroNomeMedico.Text;
            listaMedicos.Single(x => x.Crm == medico.Crm).Crm = Convert.ToInt32(txtCadastroCrmMedico.Text);
            listaMedicos.Single(x => x.Crm == medico.Crm).Especialidade = cbCadastroEspecialidadeMedico.SelectedItem.ToString();
            listaMedicos.Single(x => x.Crm == medico.Crm).ValorHora = Convert.ToDouble(txtCadastroValorHoraMedico.Text);
        }


    }
}
