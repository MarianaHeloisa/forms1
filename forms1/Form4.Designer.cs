namespace forms1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listview = new System.Windows.Forms.ListView();
            this.IdUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.MaskedTextBox();
            this.Cep = new System.Windows.Forms.MaskedTextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Endereco = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.MaskedTextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblRg = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.TextBox();
            this.LblSugestao = new System.Windows.Forms.Label();
            this.lblAten = new System.Windows.Forms.Label();
            this.lblNmae = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdUser,
            this.NameUser});
            this.listview.FullRowSelect = true;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(463, 241);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(653, 226);
            this.listview.TabIndex = 49;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            this.listview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listview_MouseDoubleClick);
            // 
            // IdUser
            // 
            this.IdUser.Text = "id";
            this.IdUser.Width = 0;
            // 
            // NameUser
            // 
            this.NameUser.Text = "Usuário";
            this.NameUser.Width = 274;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(810, 157);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 77);
            this.button2.TabIndex = 48;
            this.button2.Text = "excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 77);
            this.button1.TabIndex = 47;
            this.button1.Text = "editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(463, 474);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(653, 77);
            this.button3.TabIndex = 50;
            this.button3.Text = "voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "edite seu endereço";
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(137, 423);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(221, 22);
            this.Bairro.TabIndex = 66;
            // 
            // Cep
            // 
            this.Cep.Location = new System.Drawing.Point(137, 264);
            this.Cep.Mask = "00000-000";
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(221, 22);
            this.Cep.TabIndex = 65;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(137, 216);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(221, 22);
            this.Nome.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Digite seu CEP:";
            // 
            // Endereco
            // 
            this.Endereco.Location = new System.Drawing.Point(137, 311);
            this.Endereco.Margin = new System.Windows.Forms.Padding(4);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(220, 22);
            this.Endereco.TabIndex = 62;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(135, 346);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(118, 16);
            this.lblMail.TabIndex = 61;
            this.lblMail.Text = "Digite seu numero:";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(137, 366);
            this.Numero.Margin = new System.Windows.Forms.Padding(4);
            this.Numero.Mask = "0000";
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(220, 22);
            this.Numero.TabIndex = 60;
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(134, 291);
            this.LblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(131, 16);
            this.LblTelefone.TabIndex = 55;
            this.LblTelefone.Text = "Digite seu endereço:";
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Location = new System.Drawing.Point(135, 398);
            this.LblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(108, 16);
            this.LblRg.TabIndex = 53;
            this.LblRg.Text = "Digite seu bairro:";
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(137, 523);
            this.Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(220, 22);
            this.Estado.TabIndex = 59;
            // 
            // LblSugestao
            // 
            this.LblSugestao.AutoSize = true;
            this.LblSugestao.Location = new System.Drawing.Point(134, 503);
            this.LblSugestao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSugestao.Name = "LblSugestao";
            this.LblSugestao.Size = new System.Drawing.Size(115, 16);
            this.LblSugestao.TabIndex = 58;
            this.LblSugestao.Text = "Digite seu estado:";
            // 
            // lblAten
            // 
            this.lblAten.AutoSize = true;
            this.lblAten.Location = new System.Drawing.Point(134, 454);
            this.lblAten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAten.Name = "lblAten";
            this.lblAten.Size = new System.Drawing.Size(115, 16);
            this.lblAten.TabIndex = 56;
            this.lblAten.Text = "Digite sua cidade:";
            // 
            // lblNmae
            // 
            this.lblNmae.AutoSize = true;
            this.lblNmae.Location = new System.Drawing.Point(134, 197);
            this.lblNmae.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmae.Name = "lblNmae";
            this.lblNmae.Size = new System.Drawing.Size(107, 16);
            this.lblNmae.TabIndex = 52;
            this.lblNmae.Text = "Digite seu nome:";
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(137, 474);
            this.Cidade.Margin = new System.Windows.Forms.Padding(4);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(220, 22);
            this.Cidade.TabIndex = 57;
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Location = new System.Drawing.Point(252, 426);
            this.lblProntuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(16, 16);
            this.lblProntuario.TabIndex = 54;
            this.lblProntuario.Text = "   ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 673);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.Cep);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.LblSugestao);
            this.Controls.Add(this.lblAten);
            this.Controls.Add(this.lblNmae);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.lblProntuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editar endereço";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader IdUser;
        private System.Windows.Forms.ColumnHeader NameUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Bairro;
        private System.Windows.Forms.MaskedTextBox Cep;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Endereco;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.MaskedTextBox Numero;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.Label LblSugestao;
        private System.Windows.Forms.Label lblAten;
        private System.Windows.Forms.Label lblNmae;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Label lblProntuario;
    }
}