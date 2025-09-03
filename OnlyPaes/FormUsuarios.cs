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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OnlyPaes
{

    public partial class FormUsuarios : Form
    {
        Model.Usuario usuario;

        int idselecionado = 0;

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
        public void ResetarCampos()
        {
             AtualizarDgv();

                    txbEditarEmail.Clear();
                    txbEditarNome.Clear();
                    txbEditarSenha.Clear();
                    idselecionado = 0;
                    lblUsuApagar.Text = "Selecione um usuário para apagar:";
                    grbUsuApagar.Enabled = false;
                    grbUsuEditar.Enabled = false;
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
                if (usuarioCadastro.Cadastrar())
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
            if (txbUsuSenha.PasswordChar == '❃')
            {
                txbUsuSenha.PasswordChar = '\0';
            }
            else
            {
                txbUsuSenha.PasswordChar = '❃';
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvUsuario.SelectedCells[0].RowIndex;
            txbEditarNome.Text = dgvUsuario.Rows[ls].Cells[1].Value.ToString();
            txbEditarEmail.Text = dgvUsuario.Rows[ls].Cells[2].Value.ToString();
            grbUsuEditar.Enabled = true;

            idselecionado = (int)dgvUsuario.Rows[ls].Cells[0].Value;

            lblUsuApagar.Text = $"Apagar: {dgvUsuario.Rows[ls].Cells[1].Value}";
            grbUsuApagar.Enabled = true;
        }

        private void btnUsuApagar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este usuário?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Model.Usuario usuarioApagar = new Model.Usuario();
                usuarioApagar.Id = idselecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pibOlho2_Click(object sender, EventArgs e)
        {
            if (txbEditarSenha.PasswordChar == '❃')
            {
                txbEditarSenha.PasswordChar = '\0';
            }
            else
            {
                txbEditarSenha.PasswordChar = '❃';
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbEditarNome.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarEmail.Text.Length < 7)
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarSenha.Text.Length < 6)
            {
                MessageBox.Show("O senha deve ter no mínimo 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.Usuario usuarioEditar = new Model.Usuario();
                usuarioEditar.Id = idselecionado;
                usuarioEditar.NomeCompleto = txbEditarNome.Text;
                usuarioEditar.Email = txbEditarEmail.Text;
                usuarioEditar.Senha = txbEditarSenha.Text;
                if (usuarioEditar.Editar())
                {
                    MessageBox.Show("Informações do usuário alterada com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao editar informações do usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
