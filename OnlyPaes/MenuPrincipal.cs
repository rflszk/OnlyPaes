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
    public partial class MenuPrincipal : Form
    {
        //var global
        Model.Usuario usuario = new Model.Usuario();

        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblMenuOla.Text = $"Olá {usuario.NomeCompleto}! Escolha uma opção abaixo:";
        }

        private void btnMenuComandas_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuUser_Click(object sender, EventArgs e)
        {
            FormUsuarios formUsuarios = new FormUsuarios(usuario);
            formUsuarios.ShowDialog();
            
        }
    }
}
