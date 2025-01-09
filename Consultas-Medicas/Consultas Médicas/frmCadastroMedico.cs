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
            string crm = txtCadastroCrmMedico.Text;

            if (string.IsNullOrWhiteSpace(txtCadastroNomeMedico.Text))
            {
                MessageBox.Show("Informe o nome do médico.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            
            if (!IsCrmValid(crm))
            {
                MessageBox.Show("CRM inválido.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (cbCadastroEspecialidadeMedico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma especialidade.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCadastroValorHoraMedico.Text) || !double.TryParse(txtCadastroValorHoraMedico.Text, out double valorHora) || valorHora <= 0)
            {
                MessageBox.Show("Informe o valor da hora.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (disponibilidadeLista.Count == 0)
            {
                MessageBox.Show("Cadastre algum horário na Disponibilidade.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            try
            {
                int crmNumerico = Convert.ToInt32(crm);

                medicoLista.Add(new Medico(
                    txtCadastroNomeMedico.Text,
                    crmNumerico,
                    cbCadastroEspecialidadeMedico.Text,
                    Convert.ToDouble(txtCadastroValorHoraMedico.Text),
                    new List<DateTime>(disponibilidadeLista)
                ));

                MessageBox.Show("Cadastro realizado com sucesso.",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                txtCadastroNomeMedico.Clear();
                txtCadastroCrmMedico.Clear();
                cbCadastroEspecialidadeMedico.SelectedIndex = -1;
                txtCadastroValorHoraMedico.Clear();
                disponibilidadeLista.Clear();
                lvwDatasDisponibilidade.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o médico: {ex.Message}",
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private bool IsCrmValid(string crm)
        {
            if (string.IsNullOrWhiteSpace(crm))
                return false;

            return crm.Length == 6 && crm.All(char.IsDigit);
        }

        private void btnAdicionarData_Click(object sender, EventArgs e)
        {
            DateTime data;
            data = dtpDataDisponibilidade.Value.Date.Add(new TimeSpan(dtpHoraDisponibilidade.Value.Hour, 0, 0));
            if (!disponibilidadeLista.Contains(data))
            {
                disponibilidadeLista.Add(data);
                ListViewItem item = new ListViewItem(Convert.ToString(data));
                lvwDatasDisponibilidade.Items.Add(item);
                dtpHoraDisponibilidade.Value += new TimeSpan(1, 0, 0);
            }
            else
            {
                MessageBox.Show("Não é possível cadastrar dois horários iguais!", "Erro");
            }
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

        private void cbCadastroEspecialidadeMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCadastroCrmMedico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
