using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        private void btnmessage_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO FeedBack_ VALUES (@name, @Telefone, @Email, @cpf, @atendimento, @sugestao)";

            sqlCommand.Parameters.AddWithValue("@name", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", MtbTelefone.Text);
            sqlCommand.Parameters.AddWithValue("@email", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@cpf", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@atendimento", txbAtendimento.Text);
            sqlCommand.Parameters.AddWithValue("@sugestao", txtSuges.Text);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastro com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            txbName.Clear();
            MtbTelefone.Clear();
            textBox3.Clear();
            textBox2.Clear();
            txbAtendimento.Clear();
            txtSuges.Clear();

            

            //string name = txbName.Text;
            //string lblAten = txbAtendimento.Text;
            //string LblSugestao = txtSuges.Text;
            //string register = textBox2.Text;
            //string Telephone = MtbTelefone.Text;
            //string Email = textBox3.Text;


            //string message = "nome: " + name +
            //                "\nTelefone: " + Telephone +
            //                "\nE-mail : " + Email +
            //                 "\nCPF: " + register +
            //                 "\nAtendimento: " + lblAten +
            //                 "\nSugestão: " + LblSugestao;
                           
                             
            
            //MessageBox.Show(
            //    message,
            //    " Algo esta errado. ",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information

            //    );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPront_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
