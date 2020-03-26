using ProjetoLifety.Model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBox_email.Text = "Email";
            mskTxt_senha.Text = "Senha";
        }

        private void txtBox_email_Click(object sender, EventArgs e)
        {
            txtBox_email.Text = "";
        }

        private void mskTxt_senha_Click(object sender, EventArgs e)
        {
            mskTxt_senha.Text = "";
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtBox_email.Text, mskTxt_senha.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Bem-vindo!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Navegacao navegacao = new Navegacao();
                    navegacao.ShowDialog();

                }
                else
                {
                    MessageBox.Show("CPF ou Senha estão incorretos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

;
        }

        private void linkLbl_cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Cadastrar formCadastrar = new Form_Cadastrar();
            formCadastrar.ShowDialog();
        }
    }
}
