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
    internal class EnderecoDAO
    {
        public List<Endereco> SelectEndereco()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM ENDERECO";

            List<Endereco> enderecos = new List<Endereco>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Endereco objeto = new Endereco(
                    (int)dr["Id"],
                    (string)dr["Nome"],
                    (string)dr["CEP"],
                    (string)dr["Endereco"],
                    (string)dr["Numero"],
                    (string)dr["Bairro"],
                    (string)dr["Cidade"],
                    (string)dr["Estado"]
                    );
                    enderecos.Add(objeto);
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
            return enderecos;
        }
        public void InsertEndereco(Endereco endereco)

        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO ENDERECO VALUES
            (@nome, @cep, @endereco, @numero, @bairro, @cidade, @estado)";

            sqlCommand.Parameters.AddWithValue("@nome", endereco.Nome);
            sqlCommand.Parameters.AddWithValue("@cep", endereco.Cep);
            sqlCommand.Parameters.AddWithValue("@endereco", endereco.Endereço);
            sqlCommand.Parameters.AddWithValue("@numero", endereco.Numero);
            sqlCommand.Parameters.AddWithValue("@bairro", endereco.Bairro);
            sqlCommand.Parameters.AddWithValue("@cidade", endereco.Cidade);
            sqlCommand.Parameters.AddWithValue("@estado", endereco.Estado);

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateEndereco(int Id, Endereco endereco)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE ENDERECO SET
            Nome = @nome,
            CEP = @cep,
            Endereco = @endereco,
            Numero = @numero, 
            Bairro = @bairro,
            Cidade = @cidade,
            Estado = @estado
            WHERE Id = @id";

            sqlCommand.Parameters.AddWithValue("@nome", endereco.Nome);
            sqlCommand.Parameters.AddWithValue("@cep", endereco.Cep);
            sqlCommand.Parameters.AddWithValue("@endereco", endereco.Endereço);
            sqlCommand.Parameters.AddWithValue("@numero", endereco.Numero);
            sqlCommand.Parameters.AddWithValue("@bairro", endereco.Bairro);
            sqlCommand.Parameters.AddWithValue("@cidade", endereco.Cidade);
            sqlCommand.Parameters.AddWithValue("@estado", endereco.Estado);
            sqlCommand.Parameters.AddWithValue("@id", Id);

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteEndereco(int Id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM ENDERECO WHERE Id = @id";
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


