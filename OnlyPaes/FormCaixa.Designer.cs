namespace OnlyPaes
{
    partial class FormCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaixa));
            this.btnListar = new System.Windows.Forms.Button();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.pibDetalhe = new System.Windows.Forms.PictureBox();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.PibLogoImg = new System.Windows.Forms.PictureBox();
            this.btnEncerrarComanda = new System.Windows.Forms.Button();
            this.chbComanda = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorReais = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnListar.FlatAppearance.BorderSize = 2;
            this.btnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Location = new System.Drawing.Point(472, 94);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 38);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(366, 94);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(100, 38);
            this.txbComanda.TabIndex = 8;
            // 
            // pibDetalhe
            // 
            this.pibDetalhe.BackColor = System.Drawing.Color.Transparent;
            this.pibDetalhe.Image = global::OnlyPaes.Properties.Resources.luxa_org_opacity_changed___Microsoft_Fluentui_Emoji_Mono_Bread_1024;
            this.pibDetalhe.InitialImage = global::OnlyPaes.Properties.Resources.OnlypaesNome;
            this.pibDetalhe.Location = new System.Drawing.Point(488, 257);
            this.pibDetalhe.Name = "pibDetalhe";
            this.pibDetalhe.Size = new System.Drawing.Size(495, 315);
            this.pibDetalhe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibDetalhe.TabIndex = 14;
            this.pibDetalhe.TabStop = false;
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.AllowUserToResizeColumns = false;
            this.dgvCaixa.AllowUserToResizeRows = false;
            this.dgvCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaixa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(51, 143);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.ReadOnly = true;
            this.dgvCaixa.Size = new System.Drawing.Size(732, 252);
            this.dgvCaixa.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(363, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(103, 37);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Caixa";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.BackColor = System.Drawing.Color.Transparent;
            this.lblComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(143, 103);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(217, 25);
            this.lblComanda.TabIndex = 19;
            this.lblComanda.Text = "Número da comanda:";
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
            this.PibLogoImg.TabIndex = 20;
            this.PibLogoImg.TabStop = false;
            // 
            // btnEncerrarComanda
            // 
            this.btnEncerrarComanda.Enabled = false;
            this.btnEncerrarComanda.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEncerrarComanda.FlatAppearance.BorderSize = 2;
            this.btnEncerrarComanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnEncerrarComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrarComanda.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEncerrarComanda.Location = new System.Drawing.Point(51, 476);
            this.btnEncerrarComanda.Name = "btnEncerrarComanda";
            this.btnEncerrarComanda.Size = new System.Drawing.Size(275, 35);
            this.btnEncerrarComanda.TabIndex = 21;
            this.btnEncerrarComanda.Text = "Encerrar Comanda";
            this.btnEncerrarComanda.UseVisualStyleBackColor = true;
            this.btnEncerrarComanda.Click += new System.EventHandler(this.btnEncerrarComanda_Click);
            // 
            // chbComanda
            // 
            this.chbComanda.AutoSize = true;
            this.chbComanda.Location = new System.Drawing.Point(118, 453);
            this.chbComanda.Name = "chbComanda";
            this.chbComanda.Size = new System.Drawing.Size(129, 17);
            this.chbComanda.TabIndex = 22;
            this.chbComanda.Text = "Pagamento Recebido";
            this.chbComanda.UseVisualStyleBackColor = true;
            this.chbComanda.CheckedChanged += new System.EventHandler(this.chbComanda_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(112, 409);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 31);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "R$";
            // 
            // lblValorReais
            // 
            this.lblValorReais.AutoSize = true;
            this.lblValorReais.BackColor = System.Drawing.Color.Transparent;
            this.lblValorReais.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorReais.Location = new System.Drawing.Point(178, 409);
            this.lblValorReais.Name = "lblValorReais";
            this.lblValorReais.Size = new System.Drawing.Size(24, 31);
            this.lblValorReais.TabIndex = 24;
            this.lblValorReais.Text = "-";
            // 
            // FormCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(826, 523);
            this.Controls.Add(this.lblValorReais);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chbComanda);
            this.Controls.Add(this.btnEncerrarComanda);
            this.Controls.Add(this.PibLogoImg);
            this.Controls.Add(this.lblComanda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvCaixa);
            this.Controls.Add(this.txbComanda);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.pibDetalhe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.PictureBox pibDetalhe;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.PictureBox PibLogoImg;
        private System.Windows.Forms.Button btnEncerrarComanda;
        private System.Windows.Forms.CheckBox chbComanda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorReais;
    }
}