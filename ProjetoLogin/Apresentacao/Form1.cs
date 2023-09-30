using ProjetoLogin.Apresentacao;
using ProjetoLogin.Modelo;
using System;
using System.Windows.Forms;

namespace ProjetoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            Cadastre_se cad = new Cadastre_se();
            cad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {

                    MessageBox.Show("Logado com sucesso", " Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BemVindo bv = new BemVindo();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login Não encontrado, verifique login e senha", " Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
            else

            {
                MessageBox.Show(controle.mensagem);
            }
        }

    }

}



