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
    public partial class MenuUsuarios : Form
    {
        // Objetos Globais
        private Usuario _u;
        private int _idSelecionado;
        public MenuUsuarios(Usuario u)
        {
            InitializeComponent();
            _u = u;
            // Carregar dados do BD para o dgv:
            AtualizarDgv();


        }
        private void AtualizarDgv()
        {
            dgvUsuarios.DataSource = Banco.UsuarioDAO.ListarTudo();
        }
        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            var valida = txtCad.Text.Length > 5 &&
            txtEmailCad.Text.Length >= 6 &&
            txtSenhaCad.Text.Length >= 6;
            if (valida)
            {
                u.NomeCompleto = txtCad.Text;
                u.Email = txtEmailCad.Text;
                u.Senha = txtSenhaCad.Text;
                
                // Chamar o Cadastrar:
               if (Banco.UsuarioDAO.Cadastrar(u) == true)
                {
                    MessageBox.Show("Usuario Cadastrado");
                    // Limpar os Campos:
                    txtCad.Clear();
                    txtEmailCad.Clear();
                    txtSenhaCad.Clear();
                    // Atualizar o Dgv:
                    AtualizarDgv();
               }
                else
                {
                    MessageBox.Show("Houve um erro  no cadastro " + 
                        "Verificar as informações Digitadas");
                }                                        
            }
            else
            {
                MessageBox.Show("Verifique se você informou as informações certas");
            }


        }

        private void grbCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mostrar o GroupBox De Editar:
            // grbEdicao.Visible = false;

            // Ativar o Grb de Editar:
            grbEdicao.Enabled = true;



            // Descobrir o numero da linha da celula clicada:
            int numerolinha = dgvUsuarios.CurrentCell.RowIndex;
            // Guardar toda a linha em um Objeto DataRow:
            var linha =dgvUsuarios.Rows[numerolinha];
            // Atribuir o Valor das células aos txb do Editar:
            txtNomeCompletoEd.Text = linha.Cells[1].Value.ToString();
            txtEmailEd.Text = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnEdicao_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            u.NomeCompleto = txtNomeCompletoEd.Text;
            u.Email = txtEmailEd.Text;
            u.Senha = txtNovaSenhaEd.Text;
            u.Id = _idSelecionado;
            MessageBox.Show(u.Senha);

            // Chamar a Modificar:
            if (Banco.UsuarioDAO.Modificar(u))
            {
                MessageBox.Show("Usuario Modificado com Sucesso!");
                // limpar os Campos:
                txtCad.Clear();
                txtEmailEd.Clear();
                txtNovaSenhaEd.Clear();
                // Atualizar o Dgv:
                AtualizarDgv();
                //Esconder o GRB Do Editar:
                grbEdicao.Visible = false;  
            }
            else
            {
                MessageBox.Show("Verifique as informações Digitadas.");
            }

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
