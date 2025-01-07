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
    public partial class frmAdicionarSaldo : Form
    {
        //pacienteLista, medicoLista, especialidadeMedico, medicoSelecionado, horarioSelecionado, pacienteSelecionado

        //Formulários
        frmAgendarConsulta frmAgendarConsultaObj;

        //Listas
        List<Paciente> pacienteLista;
        List<Medico> medicoLista;
        List<String> especialidadeMedico;
        List<Consulta> consultasMarcadas;
        Medico medicoSelecionado;
        DateTime horarioSelecionado;
        public frmAdicionarSaldo(List<Paciente> pacienteLista, List<Medico> medicoLista, List<String> especialidadeMedico, Medico medicoSelecionado, DateTime horarioSelecionado, Paciente pacienteSelecionado, List<Consulta> consultasMarcadas)
        {
            InitializeComponent();
            this.pacienteLista = pacienteLista;
            this.medicoLista = medicoLista;
            this.especialidadeMedico = especialidadeMedico;
            this.medicoSelecionado = medicoSelecionado;
            this.horarioSelecionado = horarioSelecionado;
            this.consultasMarcadas = consultasMarcadas;

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
        }

        public frmAdicionarSaldo(List<Paciente> pacienteLista)
        {
            InitializeComponent();
            this.pacienteLista = pacienteLista;

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

        private void btnAdicionarSaldo_Click(object sender, EventArgs e)
        {
            int prontuarioPaciente = Convert.ToInt32(lvwConsultaPaciente.SelectedItems[0].SubItems[2].Text);
            Paciente pacienteSelecionado = pacienteLista.Single(x => x.Prontuario == prontuarioPaciente);
            pacienteSelecionado.AdicionarSaldo(Convert.ToDouble(txtAdicionarSaldoPaciente.Text));
            if (medicoLista!= null)
            {
                Form frmConsultasMedicas = this.MdiParent;
                if (frmAgendarConsultaObj == null || frmAgendarConsultaObj.IsDisposed)
                {
                    frmAgendarConsultaObj = new frmAgendarConsulta(pacienteLista, medicoLista, especialidadeMedico, medicoSelecionado, horarioSelecionado, pacienteSelecionado, consultasMarcadas);
                    frmAgendarConsultaObj.MdiParent = frmConsultasMedicas;
                    frmAgendarConsultaObj.Show();
                }
                else
                {
                    frmAgendarConsultaObj.Activate();
                }
            }
        }
    }
}


