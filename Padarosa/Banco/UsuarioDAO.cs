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
    public static class UsuarioDAO
    {
        // Logar
        public static DataTable Logar(Usuario u)
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            // Subsituir o @termo pela variavel vinda por parâmetro
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@senha", EasyEncryption.SHA.ComputeSHA256Hash(u.Senha));

            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        // Cadastrar
        public static bool Cadastrar(Usuario u)
        {
            string comando;
            comando = "INSERT INTO usuarios (nome_completo, email," +
                "senha) VALUES (@nome, @email, @senha)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", u.NomeCompleto);
            cmd.Parameters.AddWithValue("@email", u.Email);
            cmd.Parameters.AddWithValue("@senha", EasyEncryption.SHA.ComputeSHA256Hash(u.Senha));

            cmd.Prepare();
            try
            {
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
            catch
            {
                return false;
            }
        }
        // ListarTodos
        public static DataTable ListarTudo()
        {
            DataTable tabela = new DataTable();
            string comando;
            comando = "SELECT id, nome_completo, email FROM usuarios";
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Prepare();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        // Modificar
        public static bool Modificar(Usuario u)
        {
            string comando;
            if (u.Senha!= "")
            {
                comando = "UPDATE usuarios " +
               "SET nome_completo = @nome, " +
               "email = @email, " +
               "senha = @senha WHERE id = @id ";
            }
            else
            {
                comando = "UPDATE usuarios " +
              "SET nome_completo = @nome, " +
              "email = @email " +
              "WHERE id = @id";
            }
               

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Instanciar o objeto do tipo "MySqlCommand":
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id",u.Id);
            cmd.Parameters.AddWithValue("@nome", u.NomeCompleto);
            cmd.Parameters.AddWithValue("@email", u.Email);
            if(u.Senha!= "")
            {
             cmd.Parameters.AddWithValue("@senha", EasyEncryption.SHA.ComputeSHA256Hash(u.Senha));
            }

            cmd.Prepare();
            try
            {
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
            catch
            {
                return false;
            }
        }
    } 
}
 