using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length <= 3 &&
                txtSenha.Text.Length <= 3)
            {
                MessageBox.Show("Verifique as informações Digitadas");
            }
            else
            {
                var u = new LibPadarosa.Usuario();
                u.Email = txtEmail.Text;
                u.Senha = txtSenha.Text;
                var resultado = Banco.UsuarioDAO.Logar(u);
                // Verificar se o banco retornou algum Dado:

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("USUARIO E/ OU SENHA INCORRETA");
                }
                else
                {
                    // Continuar o Programa:
                    // Guardar as informações vindas do BD:
                    u.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    u.Id = int.Parse(resultado.Rows[0]["id"].ToString());
                    // Abrir a Janela:
                    var menuprincipal =  new Formularios.MenuPrincipal(u);
                    //Esconder a Janela Atual:
                    Hide();
                    //Mostrar a Nova Janela:
                    menuprincipal.ShowDialog();
                    // Ao sair da anterior,Mostrar Novamente:
                    Show();
                    // Limpar os campos de e-mail e senha:
                    txtEmail.Clear();
                    txtSenha.Clear();
                }

            }

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
