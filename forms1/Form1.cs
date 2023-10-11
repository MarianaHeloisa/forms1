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

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDAO.SelectUsuario();

            try
            {
                foreach (Usuario usuario in usuarios)
                {

                    ListViewItem lv = new ListViewItem(usuario.Id.ToString());
                    lv.SubItems.Add(usuario.Name);
                    lv.SubItems.Add(usuario.Telefone);
                    lv.SubItems.Add(usuario.Email);
                    lv.SubItems.Add(usuario.Cpf);
                    lv.SubItems.Add(usuario.Atendimento);
                    lv.SubItems.Add(usuario.Sugestao);
                    listView1.Items.Add(lv);

                }
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
           
        }




        private void btnmessage_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(
                    txbName.Text,
                    MtbTelefone.Text,
                    textBox3.Text,
                    textBox2.Text,
                    txbAtendimento.Text,
                    txtSuges.Text
                   
                    );

                UsuarioDAO DadosUsuario = new UsuarioDAO();
                DadosUsuario.InsertUsuarioDAO(usuario);

                MessageBox.Show("Cadastro com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);


            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           


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
            try
            {
                Usuario usuario = new Usuario(
                    txbName.Text,
                    MtbTelefone.Text,
                    textBox3.Text,
                    textBox2.Text,
                    txbAtendimento.Text,
                    txtSuges.Text
                    );

                UsuarioDAO DadosUsuario = new UsuarioDAO();
                DadosUsuario.InsertUsuarioDAO(usuario);

                MessageBox.Show("Atualizado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }




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

