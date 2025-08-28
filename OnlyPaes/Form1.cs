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

            }
        }
    }
}
