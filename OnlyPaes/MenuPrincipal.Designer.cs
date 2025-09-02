namespace OnlyPaes
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblMenuOla = new System.Windows.Forms.Label();
            this.btnMenuComandas = new System.Windows.Forms.Button();
            this.btnMenuProdutos = new System.Windows.Forms.Button();
            this.btnMenuCaixa = new System.Windows.Forms.Button();
            this.btnMenuUser = new System.Windows.Forms.Button();
            this.pibTitulo = new System.Windows.Forms.PictureBox();
            this.PibLogoImg = new System.Windows.Forms.PictureBox();
            this.pibDetalhe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pibTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(243, 113);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(369, 55);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Principal ";
            // 
            // lblMenuOla
            // 
            this.lblMenuOla.AutoSize = true;
            this.lblMenuOla.Location = new System.Drawing.Point(177, 178);
            this.lblMenuOla.Name = "lblMenuOla";
            this.lblMenuOla.Size = new System.Drawing.Size(489, 24);
            this.lblMenuOla.TabIndex = 1;
            this.lblMenuOla.Text = "Olá Administrador de Souza! Escolha uma opção abaixo:";
            // 
            // btnMenuComandas
            // 
            this.btnMenuComandas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnMenuComandas.FlatAppearance.BorderSize = 2;
            this.btnMenuComandas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnMenuComandas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuComandas.Location = new System.Drawing.Point(127, 276);
            this.btnMenuComandas.Name = "btnMenuComandas";
            this.btnMenuComandas.Size = new System.Drawing.Size(583, 65);
            this.btnMenuComandas.TabIndex = 2;
            this.btnMenuComandas.Text = "Comandas";
            this.btnMenuComandas.UseVisualStyleBackColor = false;
            this.btnMenuComandas.Click += new System.EventHandler(this.btnMenuComandas_Click);
            // 
            // btnMenuProdutos
            // 
            this.btnMenuProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnMenuProdutos.FlatAppearance.BorderSize = 2;
            this.btnMenuProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnMenuProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProdutos.Location = new System.Drawing.Point(127, 205);
            this.btnMenuProdutos.Name = "btnMenuProdutos";
            this.btnMenuProdutos.Size = new System.Drawing.Size(583, 65);
            this.btnMenuProdutos.TabIndex = 3;
            this.btnMenuProdutos.Text = "Produtos";
            this.btnMenuProdutos.UseVisualStyleBackColor = false;
            // 
            // btnMenuCaixa
            // 
            this.btnMenuCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnMenuCaixa.FlatAppearance.BorderSize = 2;
            this.btnMenuCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnMenuCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCaixa.Location = new System.Drawing.Point(127, 347);
            this.btnMenuCaixa.Name = "btnMenuCaixa";
            this.btnMenuCaixa.Size = new System.Drawing.Size(583, 65);
            this.btnMenuCaixa.TabIndex = 4;
            this.btnMenuCaixa.Text = "Caixa";
            this.btnMenuCaixa.UseVisualStyleBackColor = false;
            // 
            // btnMenuUser
            // 
            this.btnMenuUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnMenuUser.FlatAppearance.BorderSize = 2;
            this.btnMenuUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnMenuUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUser.Location = new System.Drawing.Point(127, 418);
            this.btnMenuUser.Name = "btnMenuUser";
            this.btnMenuUser.Size = new System.Drawing.Size(583, 65);
            this.btnMenuUser.TabIndex = 5;
            this.btnMenuUser.Text = "Usuário";
            this.btnMenuUser.UseVisualStyleBackColor = false;
            this.btnMenuUser.Click += new System.EventHandler(this.btnMenuUser_Click);
            // 
            // pibTitulo
            // 
            this.pibTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pibTitulo.Image = global::OnlyPaes.Properties.Resources.OnlypaesNome;
            this.pibTitulo.InitialImage = global::OnlyPaes.Properties.Resources.OnlypaesNome;
            this.pibTitulo.Location = new System.Drawing.Point(306, 36);
            this.pibTitulo.Name = "pibTitulo";
            this.pibTitulo.Size = new System.Drawing.Size(205, 74);
            this.pibTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTitulo.TabIndex = 10;
            this.pibTitulo.TabStop = false;
            // 
            // PibLogoImg
            // 
            this.PibLogoImg.BackColor = System.Drawing.Color.Transparent;
            this.PibLogoImg.Image = global::OnlyPaes.Properties.Resources.ChatGPT_Image_27_de_ago__de_2025__20_19_59;
            this.PibLogoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("PibLogoImg.InitialImage")));
            this.PibLogoImg.Location = new System.Drawing.Point(204, 25);
            this.PibLogoImg.Name = "PibLogoImg";
            this.PibLogoImg.Size = new System.Drawing.Size(96, 85);
            this.PibLogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PibLogoImg.TabIndex = 9;
            this.PibLogoImg.TabStop = false;
            // 
            // pibDetalhe
            // 
            this.pibDetalhe.BackColor = System.Drawing.Color.Transparent;
            this.pibDetalhe.Image = global::OnlyPaes.Properties.Resources.luxa_org_opacity_changed___Microsoft_Fluentui_Emoji_Mono_Bread_1024;
            this.pibDetalhe.InitialImage = global::OnlyPaes.Properties.Resources.OnlypaesNome;
            this.pibDetalhe.Location = new System.Drawing.Point(491, 259);
            this.pibDetalhe.Name = "pibDetalhe";
            this.pibDetalhe.Size = new System.Drawing.Size(495, 315);
            this.pibDetalhe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibDetalhe.TabIndex = 12;
            this.pibDetalhe.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(825, 522);
            this.Controls.Add(this.pibTitulo);
            this.Controls.Add(this.PibLogoImg);
            this.Controls.Add(this.btnMenuUser);
            this.Controls.Add(this.btnMenuCaixa);
            this.Controls.Add(this.btnMenuProdutos);
            this.Controls.Add(this.btnMenuComandas);
            this.Controls.Add(this.lblMenuOla);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pibDetalhe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Menu Principal ::";
            ((System.ComponentModel.ISupportInitialize)(this.pibTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblMenuOla;
        private System.Windows.Forms.Button btnMenuComandas;
        private System.Windows.Forms.Button btnMenuProdutos;
        private System.Windows.Forms.Button btnMenuCaixa;
        private System.Windows.Forms.Button btnMenuUser;
        private System.Windows.Forms.PictureBox pibTitulo;
        private System.Windows.Forms.PictureBox PibLogoImg;
        private System.Windows.Forms.PictureBox pibDetalhe;
    }
}