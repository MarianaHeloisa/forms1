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
            this.lblProntuario = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAtendimento = new System.Windows.Forms.TextBox();
            this.lblNmae = new System.Windows.Forms.Label();
            this.lblAten = new System.Windows.Forms.Label();
            this.LblSugestao = new System.Windows.Forms.Label();
            this.txtSuges = new System.Windows.Forms.TextBox();
            this.LblRg = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.MtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnmessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Location = new System.Drawing.Point(121, 290);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(16, 13);
            this.lblProntuario.TabIndex = 2;
            this.lblProntuario.Text = "   ";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(35, 94);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(102, 20);
            this.txbName.TabIndex = 1;
            // 
            // txbAtendimento
            // 
            this.txbAtendimento.Location = new System.Drawing.Point(31, 319);
            this.txbAtendimento.Name = "txbAtendimento";
            this.txbAtendimento.Size = new System.Drawing.Size(102, 20);
            this.txbAtendimento.TabIndex = 7;
            // 
            // lblNmae
            // 
            this.lblNmae.AutoSize = true;
            this.lblNmae.Location = new System.Drawing.Point(40, 78);
            this.lblNmae.Name = "lblNmae";
            this.lblNmae.Size = new System.Drawing.Size(86, 13);
            this.lblNmae.TabIndex = 0;
            this.lblNmae.Text = "Digite seu nome:";
            // 
            // lblAten
            // 
            this.lblAten.AutoSize = true;
            this.lblAten.Location = new System.Drawing.Point(29, 303);
            this.lblAten.Name = "lblAten";
            this.lblAten.Size = new System.Drawing.Size(154, 13);
            this.lblAten.TabIndex = 6;
            this.lblAten.Text = "Gostou do nosso atendimento?";
            this.lblAten.Click += new System.EventHandler(this.lblPront_Click);
            // 
            // LblSugestao
            // 
            this.LblSugestao.AutoSize = true;
            this.LblSugestao.Location = new System.Drawing.Point(28, 359);
            this.LblSugestao.Name = "LblSugestao";
            this.LblSugestao.Size = new System.Drawing.Size(168, 13);
            this.LblSugestao.TabIndex = 8;
            this.LblSugestao.Text = "Gostaria de dar alguma sugestão?";
            // 
            // txtSuges
            // 
            this.txtSuges.Location = new System.Drawing.Point(31, 375);
            this.txtSuges.Name = "txtSuges";
            this.txtSuges.Size = new System.Drawing.Size(102, 20);
            this.txtSuges.TabIndex = 9;
            // 
            // LblRg
            // 
            this.LblRg.AutoSize = true;
            this.LblRg.Location = new System.Drawing.Point(40, 236);
            this.LblRg.Name = "LblRg";
            this.LblRg.Size = new System.Drawing.Size(80, 13);
            this.LblRg.TabIndex = 2;
            this.LblRg.Text = "Digite seu CPF:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 252);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(39, 131);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(52, 13);
            this.LblTelefone.TabIndex = 4;
            this.LblTelefone.Text = "Telefone:";
            // 
            // MtbTelefone
            // 
            this.MtbTelefone.Location = new System.Drawing.Point(35, 147);
            this.MtbTelefone.Mask = "(00) 00000-0000";
            this.MtbTelefone.Name = "MtbTelefone";
            this.MtbTelefone.Size = new System.Drawing.Size(102, 20);
            this.MtbTelefone.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Para continuarmos seu FeedBack, faça seu login: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(40, 183);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(85, 13);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Digite seu E-mail";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 14;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(333, 290);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(403, 126);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOME";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TELEFONE";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-MAIL";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "CPF";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ATENDIMENTO";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "SUGESTAO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 89);
            this.button1.TabIndex = 16;
            this.button1.Text = "editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmessage
            // 
            this.btnmessage.Image = global::forms1.Properties.Resources.download_feed;
            this.btnmessage.Location = new System.Drawing.Point(468, 12);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(220, 132);
            this.btnmessage.TabIndex = 10;
            this.btnmessage.Text = "clique aqui";
            this.btnmessage.UseVisualStyleBackColor = true;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtbTelefone);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LblRg);
            this.Controls.Add(this.txtSuges);
            this.Controls.Add(this.LblSugestao);
            this.Controls.Add(this.lblAten);
            this.Controls.Add(this.lblNmae);
            this.Controls.Add(this.txbAtendimento);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblProntuario);
            this.Controls.Add(this.btnmessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAtendimento;
        private System.Windows.Forms.Label lblNmae;
        private System.Windows.Forms.Label lblAten;
        private System.Windows.Forms.Label LblSugestao;
        private System.Windows.Forms.TextBox txtSuges;
        private System.Windows.Forms.Label LblRg;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.MaskedTextBox MtbTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button1;
    }
}

