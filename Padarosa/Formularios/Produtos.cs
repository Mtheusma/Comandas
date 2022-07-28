using LibPadarosa;
using System;
using System.Collections;
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
    public partial class MenuProduto : Form
    {
        private Usuario _u;
        private int _idSelecionado;
        public MenuProduto(Usuario u)
        {
            InitializeComponent();
            _u = u;
            // Salvar o Resultado da listagem de categorias em um objeto:


            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbIdCategoriaCad.DataSource = rows;
            cmbCategoriaEd.DataSource = rows.Clone();
            // Atribuir a tabela de produtos no dgv:
            dgvUsuarios2.DataSource = Banco.ProdutoDAO.ListarTudo();

        }
    

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void Produtos_Load_1(object sender, EventArgs e)
        {

        }
        private void AtualizarDgv()
        {
            dgvUsuarios2.DataSource = Banco.ProdutoDAO.ListarTudo();
        }
        private void btnCadastrar2_Click(object sender, EventArgs e)
        {
            var u = new Produto();
            var valida = txtNomeCad.Text.Length > 3 &&
            txtPrecoCad.Text.Length >= 1;
            if (valida)
            {
                u.Nome = txtNomeCad.Text;
                u.Preco = double.Parse (txtPrecoCad.Text);
                u.IdRespcadastro = _u.Id;
                u.IdCategoria = obterIDdaString(cmbIdCategoriaCad.Text);

                // Chamar o Cadastrar:
                if (Banco.ProdutoDAO.Cadastrar(u) == true)
                {
                    MessageBox.Show("Produto Cadastrado com sucesso!");
                    // Limpar os Campos:
                    txtNomeCad.Clear();
                    txtPrecoCad.Clear();

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
        private int obterIDdaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grbEdicao2.Enabled = true;



            // Descobrir o numero da linha da celula clicada:
            int numerolinha = dgvUsuarios2.CurrentCell.RowIndex;
            // Guardar toda a linha em um Objeto DataRow:
            var linha = dgvUsuarios2.Rows[numerolinha];
            // Atribuir o Valor das células aos txb do Editar:
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
            txtNomeEd.Text = linha.Cells[1].Value.ToString();
            txtPrecoEd.Text = linha.Cells[2].Value.ToString();
           
        }
        private void btnEdicao2_Click(object sender, EventArgs e)
        {
            var u = new Produto();
            u.Nome = txtNomeEd.Text;
            u.Preco = double.Parse(txtPrecoEd.Text);
            u.Id = _idSelecionado;
            u.IdCategoria = obterIDdaString(cmbIdCategoriaCad.Text);

            // Chamar a Modificar:
            if (Banco.ProdutoDAO.Modificar(u))
            {
                MessageBox.Show("Produto modificado com Sucesso!");
                // limpar os Campos:
                txtNomeEd.Clear();
                txtPrecoEd.Clear();
                
                // Atualizar o Dgv:
                AtualizarDgv();
                //Esconder o GRB Do Editar:
                grbEdicao2.Visible = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações Digitadas.");
            }
        }
    }
}
