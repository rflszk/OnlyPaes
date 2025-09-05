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

namespace OnlyPaes
{
    public partial class FormProdutos : Form
    {
        Model.Usuario usuario;
        Produto produto = new Produto();
        int idselecionado = 0;

        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ListarCategoriaCmb();
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            dgvProdutos.DataSource = produto.Listar();
        }
        public void ResetarCampos()
        {
            AtualizarDgv();
            txbEditarNome.Clear();
            txbEditarPreco.Clear();
            
            idselecionado = 0;
            lblApagarProduto.Text = "Selecione um produto para apagar:";
            grbApagarProduto.Enabled = false;
            grbEditarProduto.Enabled = false;
        }
        public void ListarCategoriaCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            DataTable tabela = categoria.listar();
            foreach (DataRow dr in tabela.Rows)
            {
                cmbCadastrarCategoria.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbEditarCategoria.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            double preco = 0;
            if (txbCadastrarNome.Text.Length < 3)
            {
                MessageBox.Show("O nome do item deve ter ao menos 3 caracteres!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(txbCadastrarPreco.Text, out preco))
            {
                MessageBox.Show("Preço inválido! Digite um número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (preco <= 0)
            {
                MessageBox.Show("O preço deve ser maior que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Model.Produto produtoCadastro = new Model.Produto();

                produtoCadastro.Nome = txbCadastrarNome.Text;
                produtoCadastro.Preco = preco;

                //pegar a info do grb
                string categoriaSelecionada = cmbCadastrarCategoria.SelectedItem.ToString();
                string[] partes = categoriaSelecionada.Split('-');
                int Idcategoria = Convert.ToInt32(partes[0].Trim());

                produtoCadastro.IdCategoria = Idcategoria;
                produtoCadastro.IdRespCadastro = usuario.Id;
                
                if (produtoCadastro.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDgv();
                    txbCadastrarNome.Clear();
                    txbCadastrarPreco.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvProdutos.SelectedCells[0].RowIndex;
            txbEditarNome.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
            txbEditarPreco.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();
            int idCategoria = Convert.ToInt32(dgvProdutos.Rows[ls].Cells[3].Value);
            
            grbEditarProduto.Enabled = true;

            idselecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;
            lblApagarProduto.Text = $"Apagar {dgvProdutos.Rows[ls].Cells[1].Value}";
            grbApagarProduto.Enabled = true;
        }

        private void btnApagarProduto_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar este produto?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Model.Produto produtoApagar = new Model.Produto();
                produtoApagar.Id = idselecionado;
                if (produtoApagar.Apagar())
                {
                    MessageBox.Show("Produto apagado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            double preco = 0;
            if (txbEditarNome.Text.Length < 3)
            {
                MessageBox.Show("O nome do item deve ter ao menos 3 caracteres!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.TryParse(txbEditarPreco.Text, out preco))
            {
                MessageBox.Show("Preço inválido! Digite um número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (preco <= 0)
            {
                MessageBox.Show("O preço deve ser maior que zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Model.Produto produtoEditar = new Model.Produto();
                produtoEditar.Id = idselecionado;
                produtoEditar.Nome = txbEditarNome.Text;
                produtoEditar.Preco = preco;

                string itemSelecionado = cmbEditarCategoria.SelectedItem.ToString();
                string[] partes = itemSelecionado.Split('-');
                int Idcategoria = Convert.ToInt32(partes[0].Trim());
                produtoEditar.IdCategoria = Convert.ToInt32(partes[0].Trim());

                produtoEditar.IdRespCadastro = usuario.Id;
                if (produtoEditar.Editar())
                {
                    MessageBox.Show("Informações do produto alterada com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao editar informações do produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
    }
}
