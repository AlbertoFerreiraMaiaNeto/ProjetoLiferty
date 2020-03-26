using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLifety
{
    public partial class Navegacao : Form
    {
        public Navegacao()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarPacientes listarPacientes = new listarPacientes();
            listarPacientes.ShowDialog();
        }

        private void novoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novoPaciente novoPaciente = new novoPaciente();
            novoPaciente.ShowDialog();
        }

        private void listarConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarConsultas listarConsultas = new listarConsultas();
            listarConsultas.ShowDialog();
        }

        private void novaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novaConsulta novaConsulta = new novaConsulta();
            novaConsulta.ShowDialog();
        }
    }
}
