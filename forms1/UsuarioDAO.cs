using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace forms1
{
    internal class UsuarioDAO
    {
        public List<Usuario> SelectUsuario()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM FEEDBACK";

            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Usuario objeto = new Usuario(
                    (int)dr["Id"],
                    (string)dr["Nome"],
                    (string)dr["Senha"],
                    (string)dr["Telefone"],
                    (string)dr["Email"],
                    (string)dr["CPF"],
                    (string)dr["Atendimento"],
                    (string)dr["Sugestao"]
                    );
                    usuarios.Add(objeto);
                }
                dr.Close();
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return usuarios;
        }
        public void InsertUsuario(Usuario usuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO FEEDBACK VALUES
            (@nome, @senha, @telefone, @email, @cpf, @atendimento, @sugestao)";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@senha", Criptografar(usuario.Senha));
            sqlCommand.Parameters.AddWithValue("@telefone", usuario.Telefone);
            sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@atendimento", usuario.Atendimento);
            sqlCommand.Parameters.AddWithValue("@sugestao", usuario.Sugestao);

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateUsuario(int Id, Usuario usuario)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE FEEDBACK SET
            Nome = @nome,
            Senha = @senha,
            Telefone = @telefone,
            Email = @email, 
            CPF = @cpf,
            Atendimento = @atendimento,
            Sugestao = @sugestao
            WHERE Id = @id";

            sqlCommand.Parameters.AddWithValue("@nome", usuario.Nome);
            sqlCommand.Parameters.AddWithValue("@senha", Criptografar(usuario.Senha));
            sqlCommand.Parameters.AddWithValue("@telefone", usuario.Telefone);
            sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@atendimento", usuario.Atendimento);
            sqlCommand.Parameters.AddWithValue("@sugestao", usuario.Sugestao);
            sqlCommand.Parameters.AddWithValue("@id", Id);

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteUsuario(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM FEEDBACK WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", Id);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
        public static string Criptografar(string input)
        {
            // Calcular o Hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // Converter byte array para string hexadecimal
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }

}


