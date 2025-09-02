namespace OnlyPaes
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblUsuNome = new System.Windows.Forms.Label();
            this.lblUsuEmail = new System.Windows.Forms.Label();
            this.lblUsuSenha = new System.Windows.Forms.Label();
            this.txbUsuNome = new System.Windows.Forms.TextBox();
            this.txbUsuEmail = new System.Windows.Forms.TextBox();
            this.txbUsuSenha = new System.Windows.Forms.TextBox();
            this.btnUsuCadastrar = new System.Windows.Forms.Button();
            this.grbUsuEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbEditarSenha = new System.Windows.Forms.TextBox();
            this.txbEditarEmail = new System.Windows.Forms.TextBox();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.lblEditarSenha = new System.Windows.Forms.Label();
            this.lblEditarEmail = new System.Windows.Forms.Label();
            this.lblEditarNome = new System.Windows.Forms.Label();
            this.grbUsuApagar = new System.Windows.Forms.GroupBox();
            this.lblUsuApagar = new System.Windows.Forms.Label();
            this.btnUsuApagar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PibLogoImg = new System.Windows.Forms.PictureBox();
            this.pibOlho = new System.Windows.Forms.PictureBox();
            this.pibDetalhe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbUsuEditar.SuspendLayout();
            this.grbUsuApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibOlho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.AllowUserToResizeColumns = false;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(358, 106);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(444, 281);
            this.dgvUsuario.TabIndex = 0;
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.pibOlho);
            this.grbCadastro.Controls.Add(this.btnUsuCadastrar);
            this.grbCadastro.Controls.Add(this.txbUsuSenha);
            this.grbCadastro.Controls.Add(this.txbUsuEmail);
            this.grbCadastro.Controls.Add(this.txbUsuNome);
            this.grbCadastro.Controls.Add(this.lblUsuSenha);
            this.grbCadastro.Controls.Add(this.lblUsuEmail);
            this.grbCadastro.Controls.Add(this.lblUsuNome);
            this.grbCadastro.Location = new System.Drawing.Point(20, 106);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(318, 184);
            this.grbCadastro.TabIndex = 14;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblUsuNome
            // 
            this.lblUsuNome.AutoSize = true;
            this.lblUsuNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuNome.Location = new System.Drawing.Point(6, 33);
            this.lblUsuNome.Name = "lblUsuNome";
            this.lblUsuNome.Size = new System.Drawing.Size(127, 20);
            this.lblUsuNome.TabIndex = 0;
            this.lblUsuNome.Text = "Nome Completo:";
            // 
            // lblUsuEmail
            // 
            this.lblUsuEmail.AutoSize = true;
            this.lblUsuEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuEmail.Location = new System.Drawing.Point(81, 71);
            this.lblUsuEmail.Name = "lblUsuEmail";
            this.lblUsuEmail.Size = new System.Drawing.Size(52, 20);
            this.lblUsuEmail.TabIndex = 1;
            this.lblUsuEmail.Text = "Email:";
            // 
            // lblUsuSenha
            // 
            this.lblUsuSenha.AutoSize = true;
            this.lblUsuSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuSenha.Location = new System.Drawing.Point(73, 108);
            this.lblUsuSenha.Name = "lblUsuSenha";
            this.lblUsuSenha.Size = new System.Drawing.Size(60, 20);
            this.lblUsuSenha.TabIndex = 2;
            this.lblUsuSenha.Text = "Senha:";
            // 
            // txbUsuNome
            // 
            this.txbUsuNome.Location = new System.Drawing.Point(129, 33);
            this.txbUsuNome.Name = "txbUsuNome";
            this.txbUsuNome.Size = new System.Drawing.Size(144, 20);
            this.txbUsuNome.TabIndex = 3;
            // 
            // txbUsuEmail
            // 
            this.txbUsuEmail.Location = new System.Drawing.Point(129, 71);
            this.txbUsuEmail.Name = "txbUsuEmail";
            this.txbUsuEmail.Size = new System.Drawing.Size(144, 20);
            this.txbUsuEmail.TabIndex = 4;
            // 
            // txbUsuSenha
            // 
            this.txbUsuSenha.Location = new System.Drawing.Point(129, 108);
            this.txbUsuSenha.Name = "txbUsuSenha";
            this.txbUsuSenha.PasswordChar = '❃';
            this.txbUsuSenha.Size = new System.Drawing.Size(144, 20);
            this.txbUsuSenha.TabIndex = 5;
            // 
            // btnUsuCadastrar
            // 
            this.btnUsuCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnUsuCadastrar.FlatAppearance.BorderSize = 2;
            this.btnUsuCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnUsuCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuCadastrar.Location = new System.Drawing.Point(20, 143);
            this.btnUsuCadastrar.Name = "btnUsuCadastrar";
            this.btnUsuCadastrar.Size = new System.Drawing.Size(275, 35);
            this.btnUsuCadastrar.TabIndex = 6;
            this.btnUsuCadastrar.Text = "Cadastrar";
            this.btnUsuCadastrar.UseVisualStyleBackColor = false;
            this.btnUsuCadastrar.Click += new System.EventHandler(this.btnUsuCadastrar_Click);
            // 
            // grbUsuEditar
            // 
            this.grbUsuEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(90)))));
            this.grbUsuEditar.Controls.Add(this.btnEditar);
            this.grbUsuEditar.Controls.Add(this.txbEditarSenha);
            this.grbUsuEditar.Controls.Add(this.txbEditarEmail);
            this.grbUsuEditar.Controls.Add(this.txbEditarNome);
            this.grbUsuEditar.Controls.Add(this.lblEditarSenha);
            this.grbUsuEditar.Controls.Add(this.lblEditarEmail);
            this.grbUsuEditar.Controls.Add(this.lblEditarNome);
            this.grbUsuEditar.Location = new System.Drawing.Point(20, 296);
            this.grbUsuEditar.Name = "grbUsuEditar";
            this.grbUsuEditar.Size = new System.Drawing.Size(318, 184);
            this.grbUsuEditar.TabIndex = 15;
            this.grbUsuEditar.TabStop = false;
            this.grbUsuEditar.Text = "Editar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(20, 143);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(275, 35);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // txbEditarSenha
            // 
            this.txbEditarSenha.Location = new System.Drawing.Point(129, 108);
            this.txbEditarSenha.Name = "txbEditarSenha";
            this.txbEditarSenha.PasswordChar = '❃';
            this.txbEditarSenha.Size = new System.Drawing.Size(144, 20);
            this.txbEditarSenha.TabIndex = 5;
            // 
            // txbEditarEmail
            // 
            this.txbEditarEmail.Location = new System.Drawing.Point(129, 71);
            this.txbEditarEmail.Name = "txbEditarEmail";
            this.txbEditarEmail.Size = new System.Drawing.Size(144, 20);
            this.txbEditarEmail.TabIndex = 4;
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(129, 33);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(144, 20);
            this.txbEditarNome.TabIndex = 3;
            // 
            // lblEditarSenha
            // 
            this.lblEditarSenha.AutoSize = true;
            this.lblEditarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarSenha.Location = new System.Drawing.Point(73, 108);
            this.lblEditarSenha.Name = "lblEditarSenha";
            this.lblEditarSenha.Size = new System.Drawing.Size(60, 20);
            this.lblEditarSenha.TabIndex = 2;
            this.lblEditarSenha.Text = "Senha:";
            // 
            // lblEditarEmail
            // 
            this.lblEditarEmail.AutoSize = true;
            this.lblEditarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarEmail.Location = new System.Drawing.Point(81, 71);
            this.lblEditarEmail.Name = "lblEditarEmail";
            this.lblEditarEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEditarEmail.TabIndex = 1;
            this.lblEditarEmail.Text = "Email:";
            // 
            // lblEditarNome
            // 
            this.lblEditarNome.AutoSize = true;
            this.lblEditarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNome.Location = new System.Drawing.Point(6, 33);
            this.lblEditarNome.Name = "lblEditarNome";
            this.lblEditarNome.Size = new System.Drawing.Size(127, 20);
            this.lblEditarNome.TabIndex = 0;
            this.lblEditarNome.Text = "Nome Completo:";
            // 
            // grbUsuApagar
            // 
            this.grbUsuApagar.Controls.Add(this.btnUsuApagar);
            this.grbUsuApagar.Controls.Add(this.lblUsuApagar);
            this.grbUsuApagar.Enabled = false;
            this.grbUsuApagar.Location = new System.Drawing.Point(358, 393);
            this.grbUsuApagar.Name = "grbUsuApagar";
            this.grbUsuApagar.Size = new System.Drawing.Size(444, 87);
            this.grbUsuApagar.TabIndex = 16;
            this.grbUsuApagar.TabStop = false;
            this.grbUsuApagar.Text = "Apagar";
            // 
            // lblUsuApagar
            // 
            this.lblUsuApagar.AutoSize = true;
            this.lblUsuApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuApagar.Location = new System.Drawing.Point(6, 16);
            this.lblUsuApagar.Name = "lblUsuApagar";
            this.lblUsuApagar.Size = new System.Drawing.Size(255, 20);
            this.lblUsuApagar.TabIndex = 0;
            this.lblUsuApagar.Text = "Selecione um usuário para apagar:";
            // 
            // btnUsuApagar
            // 
            this.btnUsuApagar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnUsuApagar.FlatAppearance.BorderSize = 2;
            this.btnUsuApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnUsuApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuApagar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUsuApagar.Location = new System.Drawing.Point(85, 46);
            this.btnUsuApagar.Name = "btnUsuApagar";
            this.btnUsuApagar.Size = new System.Drawing.Size(275, 35);
            this.btnUsuApagar.TabIndex = 1;
            this.btnUsuApagar.Text = "Apagar";
            this.btnUsuApagar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(113, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(648, 55);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Gerenciamento de Usuários";
            // 
            // PibLogoImg
            // 
            this.PibLogoImg.BackColor = System.Drawing.Color.Transparent;
            this.PibLogoImg.Image = global::OnlyPaes.Properties.Resources.ChatGPT_Image_27_de_ago__de_2025__20_19_59;
            this.PibLogoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("PibLogoImg.InitialImage")));
            this.PibLogoImg.Location = new System.Drawing.Point(20, 12);
            this.PibLogoImg.Name = "PibLogoImg";
            this.PibLogoImg.Size = new System.Drawing.Size(96, 85);
            this.PibLogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PibLogoImg.TabIndex = 18;
            this.PibLogoImg.TabStop = false;
            // 
            // pibOlho
            // 
            this.pibOlho.BackColor = System.Drawing.Color.Transparent;
            this.pibOlho.Image = global::OnlyPaes.Properties.Resources.olho;
            this.pibOlho.Location = new System.Drawing.Point(279, 108);
            this.pibOlho.Name = "pibOlho";
            this.pibOlho.Size = new System.Drawing.Size(29, 20);
            this.pibOlho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibOlho.TabIndex = 7;
            this.pibOlho.TabStop = false;
            this.pibOlho.Click += new System.EventHandler(this.pibOlho_Click);
            // 
            // pibDetalhe
            // 
            this.pibDetalhe.BackColor = System.Drawing.Color.Transparent;
            this.pibDetalhe.Image = global::OnlyPaes.Properties.Resources.luxa_org_opacity_changed___Microsoft_Fluentui_Emoji_Mono_Bread_1024;
            this.pibDetalhe.InitialImage = global::OnlyPaes.Properties.Resources.OnlypaesNome;
            this.pibDetalhe.Location = new System.Drawing.Point(489, 250);
            this.pibDetalhe.Name = "pibDetalhe";
            this.pibDetalhe.Size = new System.Drawing.Size(495, 315);
            this.pibDetalhe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibDetalhe.TabIndex = 13;
            this.pibDetalhe.TabStop = false;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(824, 523);
            this.Controls.Add(this.PibLogoImg);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbUsuApagar);
            this.Controls.Add(this.grbUsuEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.pibDetalhe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Gerenciamento de Usuários ::";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbUsuEditar.ResumeLayout(false);
            this.grbUsuEditar.PerformLayout();
            this.grbUsuApagar.ResumeLayout(false);
            this.grbUsuApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibOlho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.PictureBox pibDetalhe;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Label lblUsuSenha;
        private System.Windows.Forms.Label lblUsuEmail;
        private System.Windows.Forms.Label lblUsuNome;
        private System.Windows.Forms.Button btnUsuCadastrar;
        private System.Windows.Forms.TextBox txbUsuSenha;
        private System.Windows.Forms.TextBox txbUsuEmail;
        private System.Windows.Forms.TextBox txbUsuNome;
        private System.Windows.Forms.GroupBox grbUsuEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbEditarSenha;
        private System.Windows.Forms.TextBox txbEditarEmail;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.Windows.Forms.Label lblEditarSenha;
        private System.Windows.Forms.Label lblEditarEmail;
        private System.Windows.Forms.Label lblEditarNome;
        private System.Windows.Forms.GroupBox grbUsuApagar;
        private System.Windows.Forms.Button btnUsuApagar;
        private System.Windows.Forms.Label lblUsuApagar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox PibLogoImg;
        private System.Windows.Forms.PictureBox pibOlho;
    }
}