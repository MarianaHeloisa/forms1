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
            this.btnmessage = new System.Windows.Forms.Button();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbEnrollment = new System.Windows.Forms.TextBox();
            this.lblNmae = new System.Windows.Forms.Label();
            this.lblPront = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmessage
            // 
            this.btnmessage.Location = new System.Drawing.Point(358, 168);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(75, 23);
            this.btnmessage.TabIndex = 0;
            this.btnmessage.Text = "clica aqui";
            this.btnmessage.UseVisualStyleBackColor = true;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
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
            this.txbName.Location = new System.Drawing.Point(151, 233);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 3;
            // 
            // txbEnrollment
            // 
            this.txbEnrollment.Location = new System.Drawing.Point(151, 348);
            this.txbEnrollment.Name = "txbEnrollment";
            this.txbEnrollment.Size = new System.Drawing.Size(100, 20);
            this.txbEnrollment.TabIndex = 4;
            // 
            // lblNmae
            // 
            this.lblNmae.AutoSize = true;
            this.lblNmae.Location = new System.Drawing.Point(146, 190);
            this.lblNmae.Name = "lblNmae";
            this.lblNmae.Size = new System.Drawing.Size(33, 13);
            this.lblNmae.TabIndex = 5;
            this.lblNmae.Text = "nome";
            // 
            // lblPront
            // 
            this.lblPront.AutoSize = true;
            this.lblPront.Location = new System.Drawing.Point(146, 323);
            this.lblPront.Name = "lblPront";
            this.lblPront.Size = new System.Drawing.Size(102, 13);
            this.lblPront.TabIndex = 6;
            this.lblPront.Text = "digite seu prontuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPront);
            this.Controls.Add(this.lblNmae);
            this.Controls.Add(this.txbEnrollment);
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
        private System.Windows.Forms.TextBox txbEnrollment;
        private System.Windows.Forms.Label lblNmae;
        private System.Windows.Forms.Label lblPront;
    }
}

