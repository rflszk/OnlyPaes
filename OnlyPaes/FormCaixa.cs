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
    public partial class FormCaixa : Form
    {
        Model.Usuario usuario;
        public FormCaixa(Model.Usuario usuario)
        {
            InitializeComponent();    
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(txbComanda.Text.Length == 0)
            {
                MessageBox.Show("Informe o número da comanda!","erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);

                DataTable resultado = ordemComanda.BuscarPorFicha();
                if(resultado.Rows.Count > 0)
                {
                    dgvCaixa.DataSource = resultado;
                    lblValorReais.Text = resultado.Compute("sum(Total_Item)","True").ToString();
                }
                else
                {
                    dgvCaixa.DataSource=null;
                    MessageBox.Show("Não existem lançamentos nessa comanda!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

        }

        private void chbComanda_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrarComanda.Enabled = chbComanda.Checked;
        }

        private void btnEncerrarComanda_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja encerrar essa comanda?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
                ordemComanda.IdFicha = int.Parse(txbComanda.Text);
                if(ordemComanda.EncerrarComanda())
                {
                    MessageBox.Show("Comanda encerrada", "Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbComanda.Clear();
                    dgvCaixa.DataSource = null;
                    chbComanda.Checked = false;
                    btnEncerrarComanda.Enabled = false;
                    lblValorReais.Text = "-";
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar a comanda!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
