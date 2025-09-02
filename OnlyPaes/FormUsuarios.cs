using EasyEncryption;
using MySqlConnector;
using OnlyPaes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlyPaes
{

    public partial class FormUsuarios : Form
    {
        Model.Usuario usuario;

        public FormUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            AtualizarDgv();
        }
       public void AtualizarDgv()
        {
            //Mostrar info no dgv
            dgvUsuario.DataSource = usuario.Listar();
        }

        private void btnUsuCadastrar_Click(object sender, EventArgs e)
        {
            if (txbUsuNome.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbUsuEmail.Text.Length < 7)
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbUsuSenha.Text.Length < 6)
            {
                MessageBox.Show("O senha deve ter no mínimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.Usuario usuarioCadastro = new Model.Usuario();

                usuarioCadastro.NomeCompleto = txbUsuNome.Text;
                usuarioCadastro.Email = txbUsuEmail.Text;
                usuarioCadastro.Senha = txbUsuSenha.Text;
                if(usuarioCadastro.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDgv();
                    txbUsuNome.Clear();
                    txbUsuEmail.Clear();
                    txbUsuSenha.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void pibOlho_Click(object sender, EventArgs e)
        {
          
        }
    }
}
