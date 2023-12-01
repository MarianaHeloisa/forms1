using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace forms1
{
    public partial class Form4 : Form
    {
        private int Id;
        public Form4()
        {
            InitializeComponent();
            UpdateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateListView()
        {
            listview.Items.Clear();
            EnderecoDAO enderecoDAO = new EnderecoDAO();
            List<Endereco> enderecos = enderecoDAO.SelectEndereco();

            try
            {
                foreach (Endereco endereco in enderecos)
                {
                    ListViewItem lv = new ListViewItem(endereco.Id.ToString());
                    lv.SubItems.Add(endereco.Nome);
                    lv.SubItems.Add(endereco.Cep);
                    lv.SubItems.Add(endereco.Endereço);
                    lv.SubItems.Add(endereco.Numero);
                    lv.SubItems.Add(endereco.Bairro);
                    lv.SubItems.Add(endereco.Cidade);
                    lv.SubItems.Add(endereco.Estado);
                    listview.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = Nome.Text;
                string cep = Cep.Text;
                string numero = Numero.Text;
                string endereço = Endereco.Text;
                string bairro = Bairro.Text;
                string cidade = Cidade.Text;
                string estado = Estado.Text;

                Endereco endereco = new Endereco(
                    Id,
                    Nome.Text,
                    Cep.Text,
                    Endereco.Text,
                    Numero.Text,
                    Bairro.Text,
                    Cidade.Text,
                    Estado.Text
                    );

                EnderecoDAO enderecoDAO = new EnderecoDAO();
                enderecoDAO.UpdateEndereco(Id, endereco);

                string message = "Nome: " + nome +
                             "\nCEP: " + cep +
                             "\nNúmero: " + numero +
                             "\nEndereço: " + endereço +
                             "\nBairro: " + bairro +
                             "\nCidade: " + cidade +
                             "\nEstado: " + estado;

                MessageBox.Show(message,
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                MessageBox.Show("Cadastro atualizado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Nome.Clear();
                Cep.Clear();
                Numero.Clear();
                Endereco.Clear();
                Bairro.Clear();
                Cidade.Clear();
                Estado.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Endereco endereco = new Endereco(
                    Id,
                    Nome.Text,
                    Cep.Text,
                    Endereco.Text,
                    Numero.Text,
                    Bairro.Text,
                    Cidade.Text,
                    Estado.Text
                    );
                EnderecoDAO enderecoDAO = new EnderecoDAO();
                enderecoDAO.DeleteEndereco(Id);

                MessageBox.Show("Excluido com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            Nome.Clear();
            Cep.Clear();
            Numero.Clear();
            Endereco.Clear();
            Bairro.Clear();
            Cidade.Clear();
            Estado.Clear();

            UpdateListView();
        }

        private void listview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listview.FocusedItem.Index;
            Id = int.Parse(listview.Items[index].SubItems[0].Text);
            Nome.Text = listview.Items[index].SubItems[1].Text;
            Cep.Text = listview.Items[index].SubItems[2].Text;
            Endereco.Text = listview.Items[index].SubItems[3].Text;
            Numero.Text = listview.Items[index].SubItems[4].Text;
            Bairro.Text = listview.Items[index].SubItems[5].Text;
            Cidade.Text = listview.Items[index].SubItems[6].Text;
            Estado.Text = listview.Items[index].SubItems[7].Text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
