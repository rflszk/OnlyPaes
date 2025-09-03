using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyPaes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if(txbemail.Text.Length < 6)
            {
                MessageBox.Show("Digite um Email válido!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbsenha.Text.Length < 4)
            {
                MessageBox.Show("Digite uma Senha válida!","Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
             Model.Usuario usuario = new Model.Usuario();

                usuario.Email = txbemail.Text;
                usuario.Senha = txbsenha.Text;

                DataTable resultado = usuario.Logar();

                if(resultado.Rows.Count == 0)
                {
                    MessageBox.Show("E-mail e/ou senha inválidos!","Erro", MessageBoxButtons.OK,MessageBoxIcon.Error );
                }
                else
                {
                    usuario.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                }

                //Mostrar o menu principal
                MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                Hide();
                menuPrincipal.ShowDialog();
                Show();


            }
        }

        private void pibOlho_Click(object sender, EventArgs e)
        {
            if (txbsenha.PasswordChar == '❃')
            {
                txbsenha.PasswordChar = '\0';
            }
            else
            {
                txbsenha.PasswordChar = '❃';
            }
        }
    }
}
