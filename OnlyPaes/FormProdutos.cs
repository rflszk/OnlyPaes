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
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ListarCategoriaCmb();
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
    }
}
