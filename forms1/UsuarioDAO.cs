using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace forms1
{
    internal class UsuarioDAO
    {
        public bool LoginUsuario(string CPF, string Senha)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM FeedBack_  WHERE" + " FeedBack_ = @CPF AND Senha = @Senha"; 

            sqlCom.Parameters.AddWithValue("@CPF", CPF);
            sqlCom.Parameters.AddWithValue("@Senha", Senha);



            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();
                if (dr.Read())
                {

                    dr.Close();
                    return true;
                }


                dr.Close();
                return false;

            }
            catch (Exception err)
            {
               throw new Exception (err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
           
        }


        public List<Usuario> SelectUsuario()
        {

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM FeedBack_";

            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Usuario usuario = new Usuario(

                   (int)dr["Id"],
                   (string)dr["Nome"],
                   (string)dr["Telefone"],
                   (string)dr["Email"],
                   (string)dr["CPF"],
                   (string)dr["Atendimento"],
                   (string)dr["Sugestao"]
                   );

                    usuarios.Add(usuario);

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



        public void InsertUsuarioDAO(Usuario usuario)

        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO FeedBack_ VALUES (@name, @Telefone, @Email, @cpf, @atendimento, @sugestao)";

            sqlCommand.Parameters.AddWithValue("@name", usuario.Name);
            sqlCommand.Parameters.AddWithValue("@telefone", usuario.Telefone);
            sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@atendimento", usuario.Atendimento);
            sqlCommand.Parameters.AddWithValue("@sugestao", usuario.Sugestao);

            sqlCommand.ExecuteNonQuery();

        }

        public void UpdateUsuario(Usuario usuario)
        {


            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE FeedBack_ SET
            Nome = @name, 
            Telefone = @Telefone,
            Email = @Email, 
            CPF = @cpf,
            Atendimento = @atendimento,
            Sugestao = @sugestao
            WHERE Id = @id"
            ;

            sqlCommand.Parameters.AddWithValue("@name", usuario.Name);
            sqlCommand.Parameters.AddWithValue("@telefone", usuario.Telefone);
            sqlCommand.Parameters.AddWithValue("@email", usuario.Email);
            sqlCommand.Parameters.AddWithValue("@cpf", usuario.Cpf);
            sqlCommand.Parameters.AddWithValue("@atendimento", usuario.Atendimento);
            sqlCommand.Parameters.AddWithValue("@sugestao", usuario.Sugestao);
            sqlCommand.Parameters.AddWithValue("@ID", usuario.Id);

            sqlCommand.ExecuteNonQuery();



        }

        public void DeleteUsuario(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM FeedBack_ WHERE Id = @id";
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
    }

}


