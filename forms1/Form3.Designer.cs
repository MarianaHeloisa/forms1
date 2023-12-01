namespace forms1
{
    partial class Form3
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
            this.Bairro = new System.Windows.Forms.MaskedTextBox();
            this.Cep = new System.Windows.Forms.MaskedTextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblRg = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.TextBox();
            this.LblSugestao = new System.Windows.Forms.Label();
            this.lblAten = new System.Windows.Forms.Label();
            this.lblNmae = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.btnmessage = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Endereço = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(317, 384);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(221, 22);
            this.Bairro.TabIndex = 45;
            // 
            // Cep
            // 
            this.Cep.Location = new System.Drawing.Point(317, 225);
            this.Cep.Mask = "00000-000";
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(221, 22);
            this.Cep.TabIndex = 44;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(317, 177);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(221, 22);
            this.Nome.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Digite seu CEP:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(615, 448);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(346, 59);
            this.button3.TabIndex = 41;
            this.button3.Text = "voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(315, 307);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(118, 16);
            this.lblMail.TabIndex = 37;
            this.lblMail.Text = "Digite seu numero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Adicione seu endereço:";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(314, 252);
            this.LblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(131, 16);
            this.LblTelefone.TabIndex = 29;
            this.LblTelefone.Text = "Digite seu endereço:";
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Location = new System.Drawing.Point(315, 359);
            this.LblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(108, 16);
            this.LblRg.TabIndex = 27;
            this.LblRg.Text = "Digite seu bairro:";
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(317, 484);
            this.Estado.Margin = new System.Windows.Forms.Padding(4);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(220, 22);
            this.Estado.TabIndex = 33;
            // 
            // LblSugestao
            // 
            this.LblSugestao.AutoSize = true;
            this.LblSugestao.Location = new System.Drawing.Point(314, 464);
            this.LblSugestao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSugestao.Name = "LblSugestao";
            this.LblSugestao.Size = new System.Drawing.Size(115, 16);
            this.LblSugestao.TabIndex = 32;
            this.LblSugestao.Text = "Digite seu estado:";
            // 
            // lblAten
            // 
            this.lblAten.AutoSize = true;
            this.lblAten.Location = new System.Drawing.Point(314, 415);
            this.lblAten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAten.Name = "lblAten";
            this.lblAten.Size = new System.Drawing.Size(115, 16);
            this.lblAten.TabIndex = 30;
            this.lblAten.Text = "Digite sua cidade:";
            // 
            // lblNmae
            // 
            this.lblNmae.AutoSize = true;
            this.lblNmae.Location = new System.Drawing.Point(314, 158);
            this.lblNmae.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmae.Name = "lblNmae";
            this.lblNmae.Size = new System.Drawing.Size(107, 16);
            this.lblNmae.TabIndex = 26;
            this.lblNmae.Text = "Digite seu nome:";
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(317, 435);
            this.Cidade.Margin = new System.Windows.Forms.Padding(4);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(220, 22);
            this.Cidade.TabIndex = 31;
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Location = new System.Drawing.Point(432, 387);
            this.lblProntuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(16, 16);
            this.lblProntuario.TabIndex = 28;
            this.lblProntuario.Text = "   ";
            // 
            // btnmessage
            // 
            this.btnmessage.Location = new System.Drawing.Point(615, 247);
            this.btnmessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(346, 59);
            this.btnmessage.TabIndex = 34;
            this.btnmessage.Text = "adicionar";
            this.btnmessage.UseVisualStyleBackColor = true;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 314);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(346, 59);
            this.button4.TabIndex = 47;
            this.button4.Text = "editar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Endereço
            // 
            this.Endereço.Location = new System.Drawing.Point(316, 271);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(221, 22);
            this.Endereço.TabIndex = 48;
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(316, 326);
            this.Numero.Mask = "0000";
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(221, 22);
            this.Numero.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 59);
            this.button1.TabIndex = 50;
            this.button1.Text = "gerar relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.Cep);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.LblSugestao);
            this.Controls.Add(this.lblAten);
            this.Controls.Add(this.lblNmae);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.lblProntuario);
            this.Controls.Add(this.btnmessage);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar endereço";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox Bairro;
        private System.Windows.Forms.MaskedTextBox Cep;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.Label LblSugestao;
        private System.Windows.Forms.Label lblAten;
        private System.Windows.Forms.Label lblNmae;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Endereço;
        private System.Windows.Forms.MaskedTextBox Numero;
        private System.Windows.Forms.Button button1;
    }
}