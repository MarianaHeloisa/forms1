using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //criptografa a senha digitada no login
            string SenhaLogin = Criptografar(Senha.Text);

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            //resgata a senha do banco de dados com base no cpf do usuário
            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "SELECT * FROM FEEDBACK WHERE Cpf = @cpf";
            sqlCommand.Parameters.AddWithValue("@cpf", Cpf.Text);

            //verifica se o campo nao está vazio
            if (string.IsNullOrEmpty(Cpf.Text))
            {
                MessageBox.Show(
                    "Insira o CPF",
                    "ATENÇÂO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Cpf.Clear();
            }
            if (string.IsNullOrEmpty(Senha.Text))
            {
                MessageBox.Show(
                    "Insira a senha",
                    "ATENÇÂO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Cpf.Clear();
            }

            //faz a leitura e o armazenamento da senha do banco de dados
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string SenhaSalva = (string)reader["senha"];

                    //verifica se a senha do login e a senha do banco de dados é a mesma (ambas estão criptografadas)
                    if (SenhaLogin == SenhaSalva)
                    {
                        MessageBox.Show(
                            "Bem-vindo",
                            "ATENÇÂO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Form3 form3 = new Form3();
                        form3.ShowDialog();

                        Cpf.Clear();
                        Senha.Clear();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Usuário ou senha nao coincidem",
                            "ATENÇÂO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //abre a tela de cadastro
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //limpa os campos de CPF e Senha
            Cpf.Clear();
            Senha.Clear();
        }
        //criptografia da senha
        public static string Criptografar(string input)
        {
            // Calcula o hash
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
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //fecha o aplicativo
            Close();
        }
    }
}
