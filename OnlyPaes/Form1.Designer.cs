namespace OnlyPaes
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(156, 122);
            this.lblemail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(62, 24);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(156, 174);
            this.lblsenha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(70, 24);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha:";
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(253, 119);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(254, 29);
            this.txbemail.TabIndex = 2;
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(253, 171);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(254, 29);
            this.txbsenha.TabIndex = 3;
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(160, 233);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(347, 59);
            this.btnentrar.TabIndex = 4;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(192, 45);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(262, 33);
            this.lbltitulo.TabIndex = 5;
            this.lbltitulo.Text = "OnlyPães :: Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(688, 320);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblemail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = ":: Login ::";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label lbltitulo;
    }
}

