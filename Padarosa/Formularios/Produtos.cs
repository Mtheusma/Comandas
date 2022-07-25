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
        private MenuProduto _u;
        public MenuProduto(Usuario u)
        {
            InitializeComponent();
            // Salvar o Resultado da listagem de categorias em um objeto:


            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbCategoriaCad.DataSource = rows;
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
    }
}
