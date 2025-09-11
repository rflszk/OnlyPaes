namespace OnlyPaes
{
    partial class FormComanda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComanda));
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.grbComandasInfo = new System.Windows.Forms.GroupBox();
            this.btnComandaCont = new System.Windows.Forms.Button();
            this.txbComandaProduto = new System.Windows.Forms.TextBox();
            this.txbComandaComanda = new System.Windows.Forms.TextBox();
            this.lblComandaProduto = new System.Windows.Forms.Label();
            this.lblComandaComanda = new System.Windows.Forms.Label();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbLancamentoQuantidade = new System.Windows.Forms.TextBox();
            this.txbLancamentoProduto = new System.Windows.Forms.TextBox();
            this.lblLancamentoQuantidade = new System.Windows.Forms.Label();
            this.lblLancamentoProduto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PibLogoImg = new System.Windows.Forms.PictureBox();
            this.pibDetalhe = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.grbComandasInfo.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComandas
            // 
            this.dgvComandas.AllowUserToAddRows = false;
            this.dgvComandas.AllowUserToDeleteRows = false;
            this.dgvComandas.AllowUserToResizeColumns = false;
            this.dgvComandas.AllowUserToResizeRows = false;
            this.dgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComandas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(357, 107);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.ReadOnly = true;
            this.dgvComandas.Size = new System.Drawing.Size(444, 374);
            this.dgvComandas.TabIndex = 1;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            // 
            // grbComandasInfo
            // 
            this.grbComandasInfo.Controls.Add(this.btnComandaCont);
            this.grbComandasInfo.Controls.Add(this.txbComandaProduto);
            this.grbComandasInfo.Controls.Add(this.txbComandaComanda);
            this.grbComandasInfo.Controls.Add(this.lblComandaProduto);
            this.grbComandasInfo.Controls.Add(this.lblComandaComanda);
            this.grbComandasInfo.Location = new System.Drawing.Point(21, 107);
            this.grbComandasInfo.Name = "grbComandasInfo";
            this.grbComandasInfo.Size = new System.Drawing.Size(318, 184);
            this.grbComandasInfo.TabIndex = 15;
            this.grbComandasInfo.TabStop = false;
            this.grbComandasInfo.Text = "Informações";
            // 
            // btnComandaCont
            // 
            this.btnComandaCont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnComandaCont.FlatAppearance.BorderSize = 2;
            this.btnComandaCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnComandaCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComandaCont.Location = new System.Drawing.Point(20, 143);
            this.btnComandaCont.Name = "btnComandaCont";
            this.btnComandaCont.Size = new System.Drawing.Size(275, 35);
            this.btnComandaCont.TabIndex = 6;
            this.btnComandaCont.Text = "Continuar";
            this.btnComandaCont.UseVisualStyleBackColor = false;
            this.btnComandaCont.Click += new System.EventHandler(this.btnComandaCont_Click);
            // 
            // txbComandaProduto
            // 
            this.txbComandaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComandaProduto.Location = new System.Drawing.Point(213, 86);
            this.txbComandaProduto.Name = "txbComandaProduto";
            this.txbComandaProduto.Size = new System.Drawing.Size(82, 44);
            this.txbComandaProduto.TabIndex = 4;
            // 
            // txbComandaComanda
            // 
            this.txbComandaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComandaComanda.Location = new System.Drawing.Point(213, 30);
            this.txbComandaComanda.Name = "txbComandaComanda";
            this.txbComandaComanda.Size = new System.Drawing.Size(82, 44);
            this.txbComandaComanda.TabIndex = 3;
            // 
            // lblComandaProduto
            // 
            this.lblComandaProduto.AutoSize = true;
            this.lblComandaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaProduto.Location = new System.Drawing.Point(14, 92);
            this.lblComandaProduto.Name = "lblComandaProduto";
            this.lblComandaProduto.Size = new System.Drawing.Size(195, 31);
            this.lblComandaProduto.TabIndex = 1;
            this.lblComandaProduto.Text = "Cod. Produto:";
            // 
            // lblComandaComanda
            // 
            this.lblComandaComanda.AutoSize = true;
            this.lblComandaComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComandaComanda.Location = new System.Drawing.Point(60, 36);
            this.lblComandaComanda.Name = "lblComandaComanda";
            this.lblComandaComanda.Size = new System.Drawing.Size(147, 31);
            this.lblComandaComanda.TabIndex = 0;
            this.lblComandaComanda.Text = "Comanda:";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnCancelar);
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.txbLancamentoQuantidade);
            this.grbLancamento.Controls.Add(this.txbLancamentoProduto);
            this.grbLancamento.Controls.Add(this.lblLancamentoQuantidade);
            this.grbLancamento.Controls.Add(this.lblLancamentoProduto);
            this.grbLancamento.Enabled = false;
            this.grbLancamento.Location = new System.Drawing.Point(21, 297);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(318, 184);
            this.grbLancamento.TabIndex = 16;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(184)))), ((int)(((byte)(97)))));
            this.btnLancar.FlatAppearance.BorderSize = 2;
            this.btnLancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(200)))), ((int)(((byte)(114)))));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Location = new System.Drawing.Point(20, 102);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(275, 35);
            this.btnLancar.TabIndex = 6;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbLancamentoQuantidade
            // 
            this.txbLancamentoQuantidade.Location = new System.Drawing.Point(131, 71);
            this.txbLancamentoQuantidade.Name = "txbLancamentoQuantidade";
            this.txbLancamentoQuantidade.Size = new System.Drawing.Size(164, 20);
            this.txbLancamentoQuantidade.TabIndex = 4;
            // 
            // txbLancamentoProduto
            // 
            this.txbLancamentoProduto.Location = new System.Drawing.Point(131, 33);
            this.txbLancamentoProduto.Name = "txbLancamentoProduto";
            this.txbLancamentoProduto.ReadOnly = true;
            this.txbLancamentoProduto.Size = new System.Drawing.Size(164, 20);
            this.txbLancamentoProduto.TabIndex = 3;
            // 
            // lblLancamentoQuantidade
            // 
            this.lblLancamentoQuantidade.AutoSize = true;
            this.lblLancamentoQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamentoQuantidade.Location = new System.Drawing.Point(36, 71);
            this.lblLancamentoQuantidade.Name = "lblLancamentoQuantidade";
            this.lblLancamentoQuantidade.Size = new System.Drawing.Size(96, 20);
            this.lblLancamentoQuantidade.TabIndex = 1;
            this.lblLancamentoQuantidade.Text = "Quantidade:";
            // 
            // lblLancamentoProduto
            // 
            this.lblLancamentoProduto.AutoSize = true;
            this.lblLancamentoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamentoProduto.Location = new System.Drawing.Point(63, 33);
            this.lblLancamentoProduto.Name = "lblLancamentoProduto";
            this.lblLancamentoProduto.Size = new System.Drawing.Size(69, 20);
            this.lblLancamentoProduto.TabIndex = 0;
            this.lblLancamentoProduto.Text = "Produto:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(199, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(425, 37);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Lançamento de Comandas";
            // 
            // PibLogoImg
            // 
            this.PibLogoImg.BackColor = System.Drawing.Color.Transparent;
            this.PibLogoImg.Image = global::OnlyPaes.Properties.Resources.ChatGPT_Image_27_de_ago__de_2025__20_19_59;
            this.PibLogoImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("PibLogoImg.InitialImage")));
            this.PibLogoImg.Location = new System.Drawing.Point(24, 16);
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
            this.pibDetalhe.Location = new System.Drawing.Point(489, 260);
            this.pibDetalhe.Name = "pibDetalhe";
            this.pibDetalhe.Size = new System.Drawing.Size(495, 315);
            this.pibDetalhe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibDetalhe.TabIndex = 20;
            this.pibDetalhe.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Location = new System.Drawing.Point(20, 143);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(275, 35);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(187)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(822, 522);
            this.Controls.Add(this.PibLogoImg);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbComandasInfo);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.pibDetalhe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormComanda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Gerenciamento de Comandas ::";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.grbComandasInfo.ResumeLayout(false);
            this.grbComandasInfo.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibLogoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.GroupBox grbComandasInfo;
        private System.Windows.Forms.Button btnComandaCont;
        private System.Windows.Forms.TextBox txbComandaProduto;
        private System.Windows.Forms.TextBox txbComandaComanda;
        private System.Windows.Forms.Label lblComandaProduto;
        private System.Windows.Forms.Label lblComandaComanda;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbLancamentoQuantidade;
        private System.Windows.Forms.TextBox txbLancamentoProduto;
        private System.Windows.Forms.Label lblLancamentoQuantidade;
        private System.Windows.Forms.Label lblLancamentoProduto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox PibLogoImg;
        private System.Windows.Forms.PictureBox pibDetalhe;
        private System.Windows.Forms.Button btnCancelar;
    }
}