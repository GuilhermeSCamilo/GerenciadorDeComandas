namespace GerenciadorDeComandas.Views
{
    partial class GerenciadorComandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciadorComandas));
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.lblComanda = new System.Windows.Forms.Label();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbCodProduto = new System.Windows.Forms.TextBox();
            this.lblCodproduto = new System.Windows.Forms.Label();
            this.txbComanda = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbProdutoInfo = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.grbInformacoes.SuspendLayout();
            this.grbLancamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComandas
            // 
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(254, 64);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(238, 440);
            this.dgvComandas.TabIndex = 1;
            this.dgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellClick);
            this.dgvComandas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComandas_CellContentClick);
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Location = new System.Drawing.Point(16, 60);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(55, 13);
            this.lblComanda.TabIndex = 0;
            this.lblComanda.Text = "Comanda:";
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.btnContinuar);
            this.grbInformacoes.Controls.Add(this.txbCodProduto);
            this.grbInformacoes.Controls.Add(this.lblCodproduto);
            this.grbInformacoes.Controls.Add(this.txbComanda);
            this.grbInformacoes.Controls.Add(this.lblComanda);
            this.grbInformacoes.Location = new System.Drawing.Point(36, 64);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(197, 217);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnContinuar.Location = new System.Drawing.Point(34, 162);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(126, 30);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbCodProduto
            // 
            this.txbCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodProduto.Location = new System.Drawing.Point(81, 98);
            this.txbCodProduto.Name = "txbCodProduto";
            this.txbCodProduto.Size = new System.Drawing.Size(100, 31);
            this.txbCodProduto.TabIndex = 3;
            // 
            // lblCodproduto
            // 
            this.lblCodproduto.AutoSize = true;
            this.lblCodproduto.Location = new System.Drawing.Point(16, 110);
            this.lblCodproduto.Name = "lblCodproduto";
            this.lblCodproduto.Size = new System.Drawing.Size(69, 13);
            this.lblCodproduto.TabIndex = 2;
            this.lblCodproduto.Text = "Cod Produto:";
            // 
            // txbComanda
            // 
            this.txbComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComanda.Location = new System.Drawing.Point(81, 48);
            this.txbComanda.Name = "txbComanda";
            this.txbComanda.Size = new System.Drawing.Size(100, 31);
            this.txbComanda.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(125, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Gerenciador De Comandas";
            // 
            // grbLancamento
            // 
            this.grbLancamento.Controls.Add(this.btnLancar);
            this.grbLancamento.Controls.Add(this.txbQuantidade);
            this.grbLancamento.Controls.Add(this.lblQuantidade);
            this.grbLancamento.Controls.Add(this.txbProdutoInfo);
            this.grbLancamento.Controls.Add(this.lblProduto);
            this.grbLancamento.Location = new System.Drawing.Point(36, 287);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(197, 217);
            this.grbLancamento.TabIndex = 5;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamentos";
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnLancar.Location = new System.Drawing.Point(34, 162);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(126, 30);
            this.btnLancar.TabIndex = 4;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(81, 98);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(100, 31);
            this.txbQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(16, 110);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txbProdutoInfo
            // 
            this.txbProdutoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProdutoInfo.Location = new System.Drawing.Point(81, 48);
            this.txbProdutoInfo.Name = "txbProdutoInfo";
            this.txbProdutoInfo.ReadOnly = true;
            this.txbProdutoInfo.Size = new System.Drawing.Size(100, 31);
            this.txbProdutoInfo.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(16, 60);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.Location = new System.Drawing.Point(129, 510);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // GerenciadorComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 564);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.grbInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciadorComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciadorComandas";
            this.Load += new System.EventHandler(this.GerenciadorComandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbCodProduto;
        private System.Windows.Forms.Label lblCodproduto;
        private System.Windows.Forms.TextBox txbComanda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbProdutoInfo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnCancelar;
    }
}