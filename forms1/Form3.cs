using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;

namespace forms1
{
    public partial class Form3 : Form
    {
        private int Id;
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void btnmessage_Click(object sender, EventArgs e)
        {
            //insere o endereço
            try
            {
                string nome = Nome.Text;
                string cep = Cep.Text;
                string numero = Numero.Text;
                string endereço = Endereço.Text;
                string bairro = Bairro.Text;
                string cidade = Cidade.Text;
                string estado = Estado.Text;

                Endereco endereco = new Endereco(
                    Id,
                    Nome.Text,
                    Cep.Text,
                    Endereço.Text,
                    Numero.Text,
                    Bairro.Text,
                    Cidade.Text,
                    Estado.Text
                    );

                EnderecoDAO enderecoDAO = new EnderecoDAO();
                enderecoDAO.InsertEndereco(endereco);

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

                MessageBox.Show("Cadastro com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Nome.Clear();
                Cep.Clear();
                Numero.Clear();
                Endereço.Clear();
                Bairro.Clear();
                Cidade.Clear();
                Estado.Clear();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Nome.Text))
                {
                    MessageBox.Show(
                        "Insira o Nome para gerar o relatório",
                        "ATENÇÂO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Nome.Clear();
                }
                //define os campos do relatório
                string nome, cep, numero, endereço, bairro, cidade, estado;

                //realiza a conexão e resgata os dados do banco de dados
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = "SELECT * FROM ENDERECO WHERE Nome = @nome";
                sqlCommand.Parameters.AddWithValue("@nome", Nome.Text);

                //faz a leitura e o armazenamento desses dados
                using (SqlDataReader reader1 = sqlCommand.ExecuteReader())
                {
                    reader1.Read();

                    nome = (string)reader1["Nome"];
                    cep = (string)reader1["Cep"];
                    endereço = (string)reader1["Endereco"];
                    numero = (string)reader1["Numero"];
                    bairro = (string)reader1["Bairro"];
                    cidade = (string)reader1["Cidade"];
                    estado = (string)reader1["Estado"];
                }

                //define o caminho que o arquivo ficará salvo
                string Caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string NomeArquivo = "relatorio_" + Nome.Text + ".pdf";
                string CaminhoCompleto = Path.Combine(Caminho, NomeArquivo);
                FileStream ArquivoPDF = new FileStream(CaminhoCompleto, FileMode.Create);
                Document Documento = new Document(PageSize.A4);
                PdfWriter pdfwriter = PdfWriter.GetInstance(Documento, ArquivoPDF);

                string dados = "";

                //define o texto e a formatação do primeiro paragrafo
                Paragraph Paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, (int)System.Drawing.FontStyle.Bold));
                Paragrafo1.Alignment = Element.ALIGN_LEFT;
                Paragrafo1.Add("FEEDBACK");

                //define o texto e a formatação do segundo paragrafo
                Paragraph Paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, (int)System.Drawing.FontStyle.Regular));
                Paragrafo2.Alignment = Element.ALIGN_LEFT;
                Paragrafo2.Add("Dados do Usuário:\n" + "Nome: " + nome + "\nCEP: " + cep + "\n Endereço: " + endereço + "\nNumero: " + numero + "\nBairro: " + bairro + "\nCidade: " + cidade + "\nEstado: " + estado);

                //cria o documento
                Documento.Open();
                Documento.Add(Paragrafo1);
                Documento.Add(Paragrafo2);
                Documento.Close();

                //exibe que deu tudo certo
                MessageBox.Show(
                "O relatório foi criado com sucesso",
                "ATENÇÃO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao criar o relatório");
            }

        }
    }
}

