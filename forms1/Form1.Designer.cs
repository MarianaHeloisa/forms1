namespace forms1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblProntuario = new System.Windows.Forms.Label();
            this.Atendimento = new System.Windows.Forms.TextBox();
            this.lblNmae = new System.Windows.Forms.Label();
            this.lblAten = new System.Windows.Forms.Label();
            this.LblSugestao = new System.Windows.Forms.Label();
            this.Sugestao = new System.Windows.Forms.TextBox();
            this.LblRg = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmessage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.listview = new System.Windows.Forms.ListView();
            this.IdUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Senha = new System.Windows.Forms.MaskedTextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Location = new System.Drawing.Point(211, 319);
            this.lblProntuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(16, 16);
            this.lblProntuario.TabIndex = 2;
            this.lblProntuario.Text = "   ";
            // 
            // Atendimento
            // 
            this.Atendimento.Location = new System.Drawing.Point(95, 366);
            this.Atendimento.Margin = new System.Windows.Forms.Padding(4);
            this.Atendimento.Name = "Atendimento";
            this.Atendimento.Size = new System.Drawing.Size(221, 22);
            this.Atendimento.TabIndex = 7;
            // 
            // lblNmae
            // 
            this.lblNmae.AutoSize = true;
            this.lblNmae.Location = new System.Drawing.Point(92, 90);
            this.lblNmae.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNmae.Name = "lblNmae";
            this.lblNmae.Size = new System.Drawing.Size(107, 16);
            this.lblNmae.TabIndex = 0;
            this.lblNmae.Text = "Digite seu nome:";
            // 
            // lblAten
            // 
            this.lblAten.AutoSize = true;
            this.lblAten.Location = new System.Drawing.Point(91, 346);
            this.lblAten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAten.Name = "lblAten";
            this.lblAten.Size = new System.Drawing.Size(193, 16);
            this.lblAten.TabIndex = 6;
            this.lblAten.Text = "Gostou do nosso atendimento?";
            this.lblAten.Click += new System.EventHandler(this.lblPront_Click);
            // 
            // LblSugestao
            // 
            this.LblSugestao.AutoSize = true;
            this.LblSugestao.Location = new System.Drawing.Point(91, 403);
            this.LblSugestao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSugestao.Name = "LblSugestao";
            this.LblSugestao.Size = new System.Drawing.Size(214, 16);
            this.LblSugestao.TabIndex = 8;
            this.LblSugestao.Text = "Gostaria de dar alguma sugestão?";
            // 
            // Sugestao
            // 
            this.Sugestao.Location = new System.Drawing.Point(94, 423);
            this.Sugestao.Margin = new System.Windows.Forms.Padding(4);
            this.Sugestao.Name = "Sugestao";
            this.Sugestao.Size = new System.Drawing.Size(222, 22);
            this.Sugestao.TabIndex = 9;
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Location = new System.Drawing.Point(92, 292);
            this.LblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(99, 16);
            this.LblRg.TabIndex = 2;
            this.LblRg.Text = "Digite seu CPF:";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(92, 184);
            this.LblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(64, 16);
            this.LblTelefone.TabIndex = 4;
            this.LblTelefone.Text = "Telefone:";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(95, 204);
            this.Telefone.Margin = new System.Windows.Forms.Padding(4);
            this.Telefone.Mask = "(00) 00000-0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(222, 22);
            this.Telefone.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Para continuarmos seu FeedBack, faça seu cadastro: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(92, 235);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(108, 16);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Digite seu E-mail";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(95, 255);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(222, 22);
            this.Email.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 482);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 69);
            this.button1.TabIndex = 16;
            this.button1.Text = "editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmessage
            // 
            this.btnmessage.Location = new System.Drawing.Point(94, 464);
            this.btnmessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(223, 38);
            this.btnmessage.TabIndex = 10;
            this.btnmessage.Text = "realizar cadastro";
            this.btnmessage.UseVisualStyleBackColor = true;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(833, 482);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 69);
            this.button2.TabIndex = 17;
            this.button2.Text = "excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 556);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 38);
            this.button3.TabIndex = 18;
            this.button3.Text = "voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Digite sua senha:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(95, 109);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(222, 22);
            this.Nome.TabIndex = 22;
            // 
            // listview
            // 
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdUser,
            this.NameUser});
            this.listview.FullRowSelect = true;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(486, 253);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(653, 207);
            this.listview.TabIndex = 25;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(486, 565);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(490, 20);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "concordo com as políticas de privacidade ao editar ou excluir os meus dados";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(486, 592);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(279, 20);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "gostaria de receber e-mails promocionais";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 510);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 38);
            this.button4.TabIndex = 28;
            this.button4.Text = "limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(94, 159);
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '*';
            this.Senha.Size = new System.Drawing.Size(222, 22);
            this.Senha.TabIndex = 29;
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(94, 313);
            this.CPF.Mask = "00000000000";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(225, 22);
            this.CPF.TabIndex = 34;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(840, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(486, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 207);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listview);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.Sugestao);
            this.Controls.Add(this.LblSugestao);
            this.Controls.Add(this.lblAten);
            this.Controls.Add(this.lblNmae);
            this.Controls.Add(this.Atendimento);
            this.Controls.Add(this.lblProntuario);
            this.Controls.Add(this.btnmessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.TextBox Atendimento;
        private System.Windows.Forms.Label lblNmae;
        private System.Windows.Forms.Label lblAten;
        private System.Windows.Forms.Label LblSugestao;
        private System.Windows.Forms.TextBox Sugestao;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader IdUser;
        private System.Windows.Forms.ColumnHeader NameUser;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MaskedTextBox Senha;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

