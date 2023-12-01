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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace forms1
{
    public partial class Form1 : Form
    {
        private int Id;
        public Form1()
        {
            InitializeComponent();
            UpdateListView();
        }

        private void UpdateListView()
        {
            listview.Items.Clear();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDAO.SelectUsuario();

            try
            {
                foreach (Usuario usuario in usuarios)
                {
                    ListViewItem lv = new ListViewItem(usuario.Id.ToString());
                    lv.SubItems.Add(usuario.Nome);
                    lv.SubItems.Add(usuario.Senha);
                    lv.SubItems.Add(usuario.Telefone);
                    lv.SubItems.Add(usuario.Email);
                    lv.SubItems.Add(usuario.Cpf);
                    lv.SubItems.Add(usuario.Atendimento);
                    lv.SubItems.Add(usuario.Sugestao);
                    listview.Items.Add(lv);
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
                //realiza a definição do vetor que irá armazenar o cpf e a criação das variaveis que irão funcionar na validaçãp
                int[] ValidarCpf = new int[11];
                int Validação1 = 0, Validação2 = 0;
                int Numero1 = 0, Numero2 = 0;
                decimal Numerocpf = Convert.ToDecimal(CPF.Text);

                string NumTelefone = Telefone.Text;
                string NumeroTelefone = NumTelefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                bool valido = ValidarNumeroTelefone(NumeroTelefone);

                if (valido)
                {
                    for (; ; )
                    {
                        if (Numerocpf < 10000000000 || Numerocpf > 99999999999)
                        {
                            MessageBox.Show(
                            "o CPF é inválido",
                            "ATENÇÃO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            CPF.Clear();
                            break;
                        }

                        else
                        {
                            for (int i = 10; i >= 0; i--)
                            {
                                ValidarCpf[i] = (int)(Numerocpf % 10);
                                Numerocpf /= 10;
                            }
                        }
                        //realiza a conta de multiplicação para a validação do digito 1
                        Numero1 = (((((((((ValidarCpf[0] * 10) + ValidarCpf[1] * 9) + ValidarCpf[2] * 8) + ValidarCpf[3] * 7) + ValidarCpf[4] * 6) + ValidarCpf[5] * 5) + ValidarCpf[6] * 4) + ValidarCpf[7] * 3) + ValidarCpf[8] * 2) * 10;

                        //verifica se a validação deu certo
                        if (Numero1 % 11 == ValidarCpf[9])
                        {
                            Validação1 = 1;
                        }

                        //realiza a conta de multiplicação para a validação do digito 2
                        Numero2 = ((((((((((ValidarCpf[0] * 11) + ValidarCpf[1] * 10) + ValidarCpf[2] * 9) + ValidarCpf[3] * 8) + ValidarCpf[4] * 7) + ValidarCpf[5] * 6) + ValidarCpf[6] * 5) + ValidarCpf[7] * 4) + ValidarCpf[8] * 3) + ValidarCpf[9] * 2) * 10;

                        //verifica se a validação deu certo
                        if (Numero2 % 11 == ValidarCpf[10])
                        {
                            Validação2 = 1;
                        }

                        //verifica se ambos os digitos são validos. se sim, executa a inserção do usuário
                        if (Validação1 == 1 && Validação2 == 1)
                        {
                            Usuario usuario = new Usuario(
                            Id,
                            Nome.Text,
                            Senha.Text,
                            Telefone.Text,
                            Email.Text,
                            CPF.Text,
                            Atendimento.Text,
                            Sugestao.Text
                            );

                            UsuarioDAO DadosUsuario = new UsuarioDAO();
                            DadosUsuario.InsertUsuario(usuario);

                            MessageBox.Show("Cadastro criado com sucesso",
                            "AVISO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            Nome.Clear();
                            Senha.Clear();
                            Telefone.Clear();
                            Email.Clear();
                            CPF.Clear();
                            Atendimento.Clear();
                            Sugestao.Clear();

                            UpdateListView();
                            break;
                        }
                        else
                        {
                            MessageBox.Show(
                            "o CPF é inválido",
                            "ATENÇÃO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            CPF.Clear();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                    "o Telefone é inválido",
                    "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    Telefone.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao editar o cadastro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //realiza a definição do vetor que irá armazenar o cpf e a criação das variaveis que irão funcionar na validaçãp
                int[] ValidarCpf = new int[11];
                int Validação1 = 0, Validação2 = 0;
                int Numero1 = 0, Numero2 = 0;
                decimal Numerocpf = Convert.ToDecimal(CPF.Text);

                //faz o armazenamento do numero em uma variavel
                string NumTelefone = Telefone.Text;
                string NumeroTelefone = NumTelefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                //executa a validação
                bool valido = ValidarNumeroTelefone(NumeroTelefone);

                //caso seja valido, executa o restante do codigo
                if (valido)
                {
                    for (; ; )
                    {
                        if (Numerocpf < 10000000000 || Numerocpf > 99999999999)
                        {
                            MessageBox.Show(
                            "o CPF é inválido",
                            "ATENÇÃO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            CPF.Clear();
                            break;
                        }

                        else
                        {
                            for (int i = 10; i >= 0; i--)
                            {
                                ValidarCpf[i] = (int)(Numerocpf % 10);
                                Numerocpf /= 10;
                            }
                        }
                        //realiza a conta de multiplicação para a validação do digito 1
                        Numero1 = (((((((((ValidarCpf[0] * 10) + ValidarCpf[1] * 9) + ValidarCpf[2] * 8) + ValidarCpf[3] * 7) + ValidarCpf[4] * 6) + ValidarCpf[5] * 5) + ValidarCpf[6] * 4) + ValidarCpf[7] * 3) + ValidarCpf[8] * 2) * 10;

                        //verifica se a validação deu certo
                        if (Numero1 % 11 == ValidarCpf[9])
                        {
                            Validação1 = 1;
                        }

                        //realiza a conta de multiplicação para a validação do digito 2
                        Numero2 = ((((((((((ValidarCpf[0] * 11) + ValidarCpf[1] * 10) + ValidarCpf[2] * 9) + ValidarCpf[3] * 8) + ValidarCpf[4] * 7) + ValidarCpf[5] * 6) + ValidarCpf[6] * 5) + ValidarCpf[7] * 4) + ValidarCpf[8] * 3) + ValidarCpf[9] * 2) * 10;

                        //verifica se a validação deu certo
                        if (Numero2 % 11 == ValidarCpf[10])
                        {
                            Validação2 = 1;
                        }

                        //verifica se ambos os digitos são validos. se sim, executa a inserção do usuário
                        if (Validação1 == 1 && Validação2 == 1)
                        {
                            //atualiza o usuário
                            Usuario usuario = new Usuario(
                            Id,
                            Nome.Text,
                            Senha.Text,
                            Telefone.Text,
                            Email.Text,
                            CPF.Text,
                            Atendimento.Text,
                            Sugestao.Text
                            );

                            UsuarioDAO DadosUsuario = new UsuarioDAO();
                            DadosUsuario.UpdateUsuario(Id, usuario);

                            MessageBox.Show("Cadastro atualizado com sucesso",
                            "AVISO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                            Nome.Clear();
                            Senha.Clear();
                            Telefone.Clear();
                            Email.Clear();
                            CPF.Clear();
                            Atendimento.Clear();
                            Sugestao.Clear();

                            UpdateListView();
                            break;
                        }
                        else
                        {
                            MessageBox.Show(
                            "o CPF é inválido",
                            "ATENÇÃO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            CPF.Clear();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                    "o Telefone é inválido",
                    "ATENÇÃO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    Telefone.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao editar o cadastro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //deleta o usuário
                Usuario usuario = new Usuario(
                    Id,
                    Nome.Text,
                    Senha.Text,
                    Telefone.Text,
                    Email.Text,
                    CPF.Text,
                    Atendimento.Text,
                    Sugestao.Text
                    );

                UsuarioDAO DadosUsuario = new UsuarioDAO();
                DadosUsuario.DeleteUsuario(Id);

                MessageBox.Show("Excluido com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                Nome.Clear();
                Senha.Clear();
                Telefone.Clear();
                Email.Clear();
                CPF.Clear();
                Atendimento.Clear();
                Sugestao.Clear();

                UpdateListView();
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
        static bool ValidarNumeroTelefone(string numero)
        {
            //usa um padrão para validar se o numero está nas normas brasileiras
            string padrao = @"^([1-9]{2}|[1-9]{2})9\d{8}$";

            return Regex.IsMatch(numero, padrao);
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void listview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //retorna os dados do usuário ao clicar duas vezes na listview
            int index;
            index = listview.FocusedItem.Index;
            Id = int.Parse(listview.Items[index].SubItems[0].Text);
            Nome.Text = listview.Items[index].SubItems[1].Text;
            Email.Text = listview.Items[index].SubItems[4].Text;
            Telefone.Text = listview.Items[index].SubItems[3].Text;
            CPF.Text = listview.Items[index].SubItems[5].Text;
            Atendimento.Text = listview.Items[index].SubItems[6].Text;
            Sugestao.Text = listview.Items[index].SubItems[7].Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //limpa os campos digitados pelo usuário
            Nome.Clear();
            Senha.Clear();
            Telefone.Clear();
            Email.Clear();
            CPF.Clear();
            Atendimento.Clear();
            Sugestao.Clear();
        }
    }
}

