namespace OnlyPaes
{
    partial class FormProdutos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.cmbCadastrarCategoria = new System.Windows.Forms.ComboBox();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.txbCadastrarPreco = new System.Windows.Forms.TextBox();
            this.txbCadastrarNome = new System.Windows.Forms.TextBox();
            this.lblCadastrarCategoria = new System.Windows.Forms.Label();
            this.lblCadastrarPreco = new System.Windows.Forms.Label();
            this.lblCadastrarNome = new System.Windows.Forms.Label();
            this.grbEditarProduto = new System.Windows.Forms.GroupBox();
            this.cmbEditarCategoria = new System.Windows.Forms.ComboBox();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.txbEditarPreco = new System.Windows.Forms.TextBox();
            this.txbEditarNome = new System.Windows.Forms.TextBox();
            this.lblEditarCategoria = new System.Windows.Forms.Label();
            this.lblEditarPreco = new System.Windows.Forms.Label();
            this.lblEditarNome = new System.Windows.Forms.Label();
            this.grbApagarProduto = new System.Windows.Forms.GroupBox();
            this.btnApagarProduto = new System.Windows.Forms.Button();
            this.lblApagarProduto = new System.Windows.Forms.Label();
            this.lblTituloProduto = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PibLogoImg = new System.Windows.Forms.PictureBox();
            this.pibDetalhe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditarProduto.SuspendLayout();
            this.grbApagarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(359, 107);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(445, 280);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.cmbCadastrarCategoria);
            this.grbCadastro.Controls.Add(this.btnCadastrarProduto);
            this.grbCadastro.Controls.Add(this.txbCadastrarPreco);
            this.grbCadastro.Controls.Add(this.txbCadastrarNome);
            this.grbCadastro.Controls.Add(this.lblCadastrarCategoria);
            this.grbCadastro.Controls.Add(this.lblCadastrarPreco);
            this.grbCadastro.Controls.Add(this.lblCadastrarNome);
            this.grbCadastro.Location = new System.Drawing.Point(22, 107);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(318, 184);
            this.grbCadastro.TabIndex = 15;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // cmbCadastrarCategoria
            // 
            this.cmbCadastrarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCadastrarCategoria.FormattingEnabled = true;
            this.cmbCadastrarCategoria.Location = new System.Drawing.Point(129, 106);
            this.cmbCadastrarCategoria.Name = "cmbCadastrarCategoria";
            this.cmbCadastrarCategoria.Size = new System.Drawing.Size(144, 21);
            this.cmbCadastrarCategoria.TabIndex = 8;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnCadastrarProduto.FlatAppearance.BorderSize = 2;
            this.btnCadastrarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(20, 143);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(275, 35);
            this.btnCadastrarProduto.TabIndex = 6;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txbCadastrarPreco
            // 
            this.txbCadastrarPreco.Location = new System.Drawing.Point(129, 71);
            this.txbCadastrarPreco.Name = "txbCadastrarPreco";
            this.txbCadastrarPreco.Size = new System.Drawing.Size(144, 20);
            this.txbCadastrarPreco.TabIndex = 4;
            // 
            // txbCadastrarNome
            // 
            this.txbCadastrarNome.Location = new System.Drawing.Point(129, 33);
            this.txbCadastrarNome.Name = "txbCadastrarNome";
            this.txbCadastrarNome.Size = new System.Drawing.Size(144, 20);
            this.txbCadastrarNome.TabIndex = 3;
            // 
            // lblCadastrarCategoria
            // 
            this.lblCadastrarCategoria.AutoSize = true;
            this.lblCadastrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarCategoria.Location = new System.Drawing.Point(47, 107);
            this.lblCadastrarCategoria.Name = "lblCadastrarCategoria";
            this.lblCadastrarCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCadastrarCategoria.TabIndex = 2;
            this.lblCadastrarCategoria.Text = "Categoria:";
            // 
            // lblCadastrarPreco
            // 
            this.lblCadastrarPreco.AutoSize = true;
            this.lblCadastrarPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarPreco.Location = new System.Drawing.Point(74, 71);
            this.lblCadastrarPreco.Name = "lblCadastrarPreco";
            this.lblCadastrarPreco.Size = new System.Drawing.Size(54, 20);
            this.lblCadastrarPreco.TabIndex = 1;
            this.lblCadastrarPreco.Text = "Preço:";
            // 
            // lblCadastrarNome
            // 
            this.lblCadastrarNome.AutoSize = true;
            this.lblCadastrarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarNome.Location = new System.Drawing.Point(74, 33);
            this.lblCadastrarNome.Name = "lblCadastrarNome";
            this.lblCadastrarNome.Size = new System.Drawing.Size(55, 20);
            this.lblCadastrarNome.TabIndex = 0;
            this.lblCadastrarNome.Text = "Nome:";
            // 
            // grbEditarProduto
            // 
            this.grbEditarProduto.Controls.Add(this.cmbEditarCategoria);
            this.grbEditarProduto.Controls.Add(this.btnEditarProduto);
            this.grbEditarProduto.Controls.Add(this.txbEditarPreco);
            this.grbEditarProduto.Controls.Add(this.txbEditarNome);
            this.grbEditarProduto.Controls.Add(this.lblEditarCategoria);
            this.grbEditarProduto.Controls.Add(this.lblEditarPreco);
            this.grbEditarProduto.Controls.Add(this.lblEditarNome);
            this.grbEditarProduto.Location = new System.Drawing.Point(22, 297);
            this.grbEditarProduto.Name = "grbEditarProduto";
            this.grbEditarProduto.Size = new System.Drawing.Size(318, 184);
            this.grbEditarProduto.TabIndex = 16;
            this.grbEditarProduto.TabStop = false;
            this.grbEditarProduto.Text = "Editar";
            // 
            // cmbEditarCategoria
            // 
            this.cmbEditarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditarCategoria.FormattingEnabled = true;
            this.cmbEditarCategoria.Location = new System.Drawing.Point(129, 106);
            this.cmbEditarCategoria.Name = "cmbEditarCategoria";
            this.cmbEditarCategoria.Size = new System.Drawing.Size(144, 21);
            this.cmbEditarCategoria.TabIndex = 8;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnEditarProduto.FlatAppearance.BorderSize = 2;
            this.btnEditarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProduto.Location = new System.Drawing.Point(20, 143);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(275, 35);
            this.btnEditarProduto.TabIndex = 6;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // txbEditarPreco
            // 
            this.txbEditarPreco.Location = new System.Drawing.Point(129, 71);
            this.txbEditarPreco.Name = "txbEditarPreco";
            this.txbEditarPreco.Size = new System.Drawing.Size(144, 20);
            this.txbEditarPreco.TabIndex = 4;
            // 
            // txbEditarNome
            // 
            this.txbEditarNome.Location = new System.Drawing.Point(129, 33);
            this.txbEditarNome.Name = "txbEditarNome";
            this.txbEditarNome.Size = new System.Drawing.Size(144, 20);
            this.txbEditarNome.TabIndex = 3;
            // 
            // lblEditarCategoria
            // 
            this.lblEditarCategoria.AutoSize = true;
            this.lblEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCategoria.Location = new System.Drawing.Point(47, 107);
            this.lblEditarCategoria.Name = "lblEditarCategoria";
            this.lblEditarCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblEditarCategoria.TabIndex = 2;
            this.lblEditarCategoria.Text = "Categoria:";
            // 
            // lblEditarPreco
            // 
            this.lblEditarPreco.AutoSize = true;
            this.lblEditarPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarPreco.Location = new System.Drawing.Point(75, 70);
            this.lblEditarPreco.Name = "lblEditarPreco";
            this.lblEditarPreco.Size = new System.Drawing.Size(54, 20);
            this.lblEditarPreco.TabIndex = 1;
            this.lblEditarPreco.Text = "Preço:";
            // 
            // lblEditarNome
            // 
            this.lblEditarNome.AutoSize = true;
            this.lblEditarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNome.Location = new System.Drawing.Point(73, 33);
            this.lblEditarNome.Name = "lblEditarNome";
            this.lblEditarNome.Size = new System.Drawing.Size(55, 20);
            this.lblEditarNome.TabIndex = 0;
            this.lblEditarNome.Text = "Nome:";
            // 
            // grbApagarProduto
            // 
            this.grbApagarProduto.Controls.Add(this.btnApagarProduto);
            this.grbApagarProduto.Controls.Add(this.lblApagarProduto);
            this.grbApagarProduto.Enabled = false;
            this.grbApagarProduto.Location = new System.Drawing.Point(360, 394);
            this.grbApagarProduto.Name = "grbApagarProduto";
            this.grbApagarProduto.Size = new System.Drawing.Size(444, 87);
            this.grbApagarProduto.TabIndex = 17;
            this.grbApagarProduto.TabStop = false;
            this.grbApagarProduto.Text = "Apagar";
            // 
            // btnApagarProduto
            // 
            this.btnApagarProduto.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnApagarProduto.FlatAppearance.BorderSize = 2;
            this.btnApagarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnApagarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarProduto.ForeColor = System.Drawing.Color.Firebrick;
            this.btnApagarProduto.Location = new System.Drawing.Point(85, 46);
            this.btnApagarProduto.Name = "btnApagarProduto";
            this.btnApagarProduto.Size = new System.Drawing.Size(275, 35);
            this.btnApagarProduto.TabIndex = 1;
            this.btnApagarProduto.Text = "Apagar";
            this.btnApagarProduto.UseVisualStyleBackColor = true;
            this.btnApagarProduto.Click += new System.EventHandler(this.btnApagarProduto_Click);
            // 
            // lblApagarProduto
            // 
            this.lblApagarProduto.AutoSize = true;
            this.lblApagarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagarProduto.Location = new System.Drawing.Point(6, 16);
            this.lblApagarProduto.Name = "lblApagarProduto";
            this.lblApagarProduto.Size = new System.Drawing.Size(258, 20);
            this.lblApagarProduto.TabIndex = 0;
            this.lblApagarProduto.Text = "Selecione um produto para apagar:";
            // 
            // lblTituloProduto
            // 
            this.lblTituloProduto.AutoSize = true;
            this.lblTituloProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProduto.Location = new System.Drawing.Point(195, 42);
            this.lblTituloProduto.Name = "lblTituloProduto";
            this.lblTituloProduto.Size = new System.Drawing.Size(442, 37);
            this.lblTituloProduto.TabIndex = 20;
            this.lblTituloProduto.Text = "Gerenciamento de Produtos";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PibLogoImg
            // 
            this.PibLogoImg.BackColor = System.Drawing.Color.Transparent;
            this.PibLogoImg.Image = global::OnlyPaes.Properties.Resources.ChatGPT_Image_27_de_ago__de_2025__20_19_59;
            this.PibLogoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("PibLogoImg.InitialImage")));
            this.PibLogoImg.Location = new System.Drawing.Point(22, 12);
            this.PibLogoImg.Name = "PibLogoImg";
            this.PibLogoImg.Size = new System.Drawing.Size(96, 85);
            this.PibLogoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PibLogoImg.TabIndex = 19;
            this.PibLogoImg.TabStop = false;
            // 
            // pibDetalhe
            // 
            this.pibDetalhe.BackColor = System.Drawing.Color.Transparent;
            this.pibDetalhe.Image = global::OnlyPaes.Properties.Resources.luxa_org_opacity_changed___Microsoft_Fluentui_Emoji_Mono_Bread_1024;
            this.pibDetalhe.InitialImage = global::OnlyPaes.Properties.Resources.OnlypaesNome;
            this.pibDetalhe.Location = new System.Drawing.Point(493, 261);
            this.pibDetalhe.Name = "pibDetalhe";
            this.pibDetalhe.Size = new System.Drawing.Size(495, 315);
            this.pibDetalhe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibDetalhe.TabIndex = 21;
            this.pibDetalhe.TabStop = false;
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(825, 524);
            this.Controls.Add(this.lblTituloProduto);
            this.Controls.Add(this.PibLogoImg);
            this.Controls.Add(this.grbApagarProduto);
            this.Controls.Add(this.grbEditarProduto);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.pibDetalhe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Gerenciamento de Produtos ::";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditarProduto.ResumeLayout(false);
            this.grbEditarProduto.PerformLayout();
            this.grbApagarProduto.ResumeLayout(false);
            this.grbApagarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.TextBox txbCadastrarPreco;
        private System.Windows.Forms.TextBox txbCadastrarNome;
        private System.Windows.Forms.Label lblCadastrarCategoria;
        private System.Windows.Forms.Label lblCadastrarPreco;
        private System.Windows.Forms.Label lblCadastrarNome;
        private System.Windows.Forms.ComboBox cmbCadastrarCategoria;
        private System.Windows.Forms.GroupBox grbEditarProduto;
        private System.Windows.Forms.ComboBox cmbEditarCategoria;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.TextBox txbEditarPreco;
        private System.Windows.Forms.TextBox txbEditarNome;
        private System.Windows.Forms.Label lblEditarCategoria;
        private System.Windows.Forms.Label lblEditarPreco;
        private System.Windows.Forms.Label lblEditarNome;
        private System.Windows.Forms.GroupBox grbApagarProduto;
        private System.Windows.Forms.Button btnApagarProduto;
        private System.Windows.Forms.Label lblApagarProduto;
        private System.Windows.Forms.PictureBox PibLogoImg;
        private System.Windows.Forms.Label lblTituloProduto;
        private System.Windows.Forms.PictureBox pibDetalhe;
        private System.Windows.Forms.ImageList imageList1;
    }
}