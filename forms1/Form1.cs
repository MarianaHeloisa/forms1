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
        private int Id;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM FeedBack_";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["Id"];
                    string name = (string)dr["Nome"];
                    string tel = (string)dr["Telefone"];
                    string email = (string)dr["Email"];
                    string cpf = (string)dr["CPF"];
                    string atendimento = (string)dr["Atendimento"];
                    string sugestao = (string)dr["Sugestao"];


                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(tel);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(cpf);
                    lv.SubItems.Add(atendimento);
                    lv.SubItems.Add(sugestao);
                    listView1.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
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

            UpdateListView();



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
            UpdateListView();
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

        private void button1_Click(object sender, EventArgs e)
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
            WHERE Id = @id";

            sqlCommand.Parameters.AddWithValue("@name", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", MtbTelefone.Text);
            sqlCommand.Parameters.AddWithValue("@email", textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@cpf", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@atendimento", txbAtendimento.Text);
            sqlCommand.Parameters.AddWithValue("@sugestao", txtSuges.Text);
            sqlCommand.Parameters.AddWithValue("@ID", Id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Atualizado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            txbName.Clear();
            MtbTelefone.Clear();
            textBox3.Clear();
            textBox2.Clear();
            txbAtendimento.Clear();
            txtSuges.Clear();

            UpdateListView();




        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int index;
            index = listView1.FocusedItem.Index;
            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txbName.Text = listView1.Items[index].SubItems[1].Text;
            textBox3.Text = listView1.Items[index].SubItems[2].Text;
            MtbTelefone.Text = listView1.Items[index].SubItems[3].Text;
            textBox2.Text = listView1.Items[index].SubItems[4].Text;
            txbAtendimento.Text = listView1.Items[index].SubItems[5].Text;
            txtSuges.Text = listView1.Items[index].SubItems[6].Text;



        }

        private void button2_Click(object sender, EventArgs e)
        {

            UsuarioDAO DadosUsuario = new UsuarioDAO();
            DadosUsuario.DeleteUsuario(Id);

            txbName.Clear();
            MtbTelefone.Clear();
            textBox3.Clear();
            textBox2.Clear();
            txbAtendimento.Clear();
            txtSuges.Clear();

            UpdateListView();

            MessageBox.Show("Deletado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);



        }





    


    


        }
    }

