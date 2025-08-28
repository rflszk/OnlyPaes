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
            this.lblLogin = new System.Windows.Forms.Label();
            this.PibLogoImg = new System.Windows.Forms.PictureBox();
            this.pibTitulo = new System.Windows.Forms.PictureBox();
            this.pibDetalhe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(156, 180);
            this.lblemail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(62, 24);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email:";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(156, 232);
            this.lblsenha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(70, 24);
            this.lblsenha.TabIndex = 1;
            this.lblsenha.Text = "Senha:";
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(253, 177);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(254, 29);
            this.txbemail.TabIndex = 2;
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(253, 229);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.PasswordChar = '❃';
            this.txbsenha.Size = new System.Drawing.Size(254, 29);
            this.txbsenha.TabIndex = 3;
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnentrar.FlatAppearance.BorderSize = 2;
            this.btnentrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.ForeColor = System.Drawing.Color.Black;
            this.btnentrar.Location = new System.Drawing.Point(160, 291);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(347, 59);
            this.btnentrar.TabIndex = 4;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(296, 124);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(91, 33);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login";
            // 
            // PibLogoImg
            // 
            this.PibLogoImg.BackColor = System.Drawing.Color.Transparent;
            this.PibLogoImg.Image = global::OnlyPaes.Properties.Resources.ChatGPT_Image_27_de_ago__de_2025__20_19_59;
            this.PibLogoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("PibLogoImg.InitialImage")));
            this.PibLogoImg.Location = new System.Drawing.Point(151, 17);
            this.PibLogoImg.Name = "PibLogoImg";
            this.PibLogoImg.Size = new System.Drawing.Size(96, 85);
            this.PibLogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PibLogoImg.TabIndex = 10;
            this.PibLogoImg.TabStop = false;
            // 
            // pibTitulo
            // 
            this.pibTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pibTitulo.Image = global::OnlyPaes.Properties.Resources.OnlypaesNome;
            this.pibTitulo.InitialImage = global::OnlyPaes.Properties.Resources.OnlypaesNome;
            this.pibTitulo.Location = new System.Drawing.Point(241, 28);
            this.pibTitulo.Name = "pibTitulo";
            this.pibTitulo.Size = new System.Drawing.Size(205, 74);
            this.pibTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTitulo.TabIndex = 7;
            this.pibTitulo.TabStop = false;
            // 
            // pibDetalhe
            // 
            this.pibDetalhe.BackColor = System.Drawing.Color.Transparent;
            this.pibDetalhe.Image = global::OnlyPaes.Properties.Resources.luxa_org_opacity_changed___Microsoft_Fluentui_Emoji_Mono_Bread_1024;
            this.pibDetalhe.InitialImage = global::OnlyPaes.Properties.Resources.OnlypaesNome;
            this.pibDetalhe.Location = new System.Drawing.Point(302, 147);
            this.pibDetalhe.Name = "pibDetalhe";
            this.pibDetalhe.Size = new System.Drawing.Size(495, 315);
            this.pibDetalhe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibDetalhe.TabIndex = 11;
            this.pibDetalhe.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(668, 388);
            this.Controls.Add(this.PibLogoImg);
            this.Controls.Add(this.pibTitulo);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.txbemail);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.pibDetalhe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Login ::";
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pibTitulo;
        private System.Windows.Forms.PictureBox PibLogoImg;
        private System.Windows.Forms.PictureBox pibDetalhe;
    }
}

