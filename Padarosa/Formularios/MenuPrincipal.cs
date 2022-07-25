using LibPadarosa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa.Formularios
{
    public partial class MenuPrincipal : Form
    {
        // Objeto Global:
        private Usuario _u;   
       


        public MenuPrincipal(Usuario u)
        {
            InitializeComponent();
            _u = u;
            lblPessoa.Text = "Olá" + u.NomeCompleto + "! Escolha uma opção abaixo:";
            // Ocultar o botao de usuario de todos,Exceto p adm:
            if(u.Id != 1)
            {
                btnUsuario.Visible = false;
            }
        }

        private void btnComandas_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var menuusuarios = new MenuUsuarios(_u);
            menuusuarios.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var menuprodutos = new MenuProduto(_u);
            menuprodutos.ShowDialog();
        }
    }
}
