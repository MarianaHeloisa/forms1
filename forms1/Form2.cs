using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            string CPF = textBox1.Text;
            string Senha = textBox2.Text;

            //Criar objeto de classe usuarioDAO
            UsuarioDAO usuario = new UsuarioDAO();


            //Chamar o metodo que verifica se 
            //o usuario e senha existem na tabela 

            if (usuario.LoginUsuario(CPF, Senha))
            {
                Form1 tela = new Form1();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("verifique os dados inseridos!",
                    "ERROUUU",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usuario.LoginUsuario(CPF, Senha))
            {
                Form1 tela = new Form1();
                tela.ShowDialog();
            }
        }
    }
}
