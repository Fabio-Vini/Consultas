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

            if (string.IsNullOrWhiteSpace(txtCadastroNomeMedico.Text))
            {
                MessageBox.Show("Informe o nome do médico.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            string crm = txtCadastroCrmMedico.Text;
            if (!IsCrmValid(crm))
            {
                MessageBox.Show("CRM inválido. O CRM deve conter 6 dígitos numéricos.",
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

            if (string.IsNullOrWhiteSpace(txtCadastroValorHoraMedico.Text) ||
                !double.TryParse(txtCadastroValorHoraMedico.Text, out double valorHora) ||
                valorHora <= 0)
            {
                MessageBox.Show("Informe um valor válido para a hora. Deve ser um número positivo.",
                                "Erro de Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            try
            {
                var medicoAtualizar = listaMedicos.Single(x => x.Crm == medico.Crm);
                medicoAtualizar.Nome = txtCadastroNomeMedico.Text;
                medicoAtualizar.Crm = int.Parse(crm);
                medicoAtualizar.Especialidade = cbCadastroEspecialidadeMedico.SelectedItem.ToString();
                medicoAtualizar.ValorHora = valorHora;
                MessageBox.Show("Dados do médico atualizados com sucesso!", "Sucesso");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Médico não encontrado na lista.",
                                "Erro de Atualização",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao atualizar o médico: {ex.Message}",
                                "Erro de Atualização",
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

        private void txtCadastroNomeMedico_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
