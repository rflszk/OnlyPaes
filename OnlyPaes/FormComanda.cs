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
    public partial class FormComanda : Form
    {
        Model.Usuario usuario;
        public FormComanda(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }
        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvComandas.DataSource = produto.Listar();

        }
        private void ResetarCampos()
        {
            txbComandaComanda.Clear();
            txbLancamentoQuantidade.Clear();
            txbComandaProduto.Clear();
            txbLancamentoProduto.Clear();
            grbLancamento.Enabled = false;
            grbComandasInfo.Enabled = true;
            AtualizarDgv();

        }
        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvComandas.SelectedCells[0].RowIndex;
            txbComandaProduto.Text = dgvComandas.Rows[ls].Cells[0].Value.ToString();
            txbLancamentoProduto.Text = dgvComandas.Rows[ls].Cells[1].Value.ToString();
        }

        private void btnComandaCont_Click(object sender, EventArgs e)
        {
            if (txbComandaComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbComandaProduto.Text.Length == 0)
            {
                MessageBox.Show("Informe o código do produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                grbComandasInfo.Enabled = false;
                grbLancamento.Enabled = true;
            }


        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if (txbLancamentoQuantidade.Text.Length == 0)
            {
                MessageBox.Show("A quantidade de produtos não pode ser igual a zero! Verfique!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComandaComanda.Text);
                ordemComanda.IdProduto = int.Parse(txbComandaProduto.Text);
                ordemComanda.Quantidade = int.Parse(txbLancamentoQuantidade.Text);
                ordemComanda.IdResp = usuario.Id;

                if(ordemComanda.Cadastrar())
                {
                    MessageBox.Show("Lançamento efetuado com sucesso!", "Show!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao efetuar lançamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarCampos();
        }
    }
}
