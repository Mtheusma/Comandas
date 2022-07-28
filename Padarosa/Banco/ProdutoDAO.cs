
using LibPadarosa;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padarosa.Banco
{
    public static class ProdutoDAO
    {
        public static bool Cadastrar(Produto p)
        {
            string comando = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro) " +
                "VALUES (@nome, @preco, @id_categoria, @id_respcadastro)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@preco", p.Preco);
            cmd.Parameters.AddWithValue("@id_categoria", p.IdCategoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", p.IdRespcadastro);

            cmd.Prepare();
            if (cmd.ExecuteNonQuery() == 0)
            {
                conexaoBD.Desconectar(con);
                return false;
            }
            else
            {
                conexaoBD.Desconectar(con);
                return true;
            }
        }
        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM view_produtos";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public static bool Modificar(Produto u)
        {
            string comando;
            
            
                comando = "UPDATE produtos " +
               "SET Nome = @nome, " +
               "preco = @preco, " +
               "id_categoria = @categoria " +
               " WHERE id = @id ";
            
           

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.Parameters.AddWithValue("@nome", u.Nome);
            cmd.Parameters.AddWithValue("@preco", u.Preco);
            cmd.Parameters.AddWithValue("@categoria", u.IdCategoria);
           
            

            cmd.Prepare();

            if (cmd.ExecuteNonQuery() == 0)
            {
                conexaoBD.Desconectar(con);
                return false;
            }
            else
            {
                conexaoBD.Desconectar(con);
                return true;
            }
        }
    }

}