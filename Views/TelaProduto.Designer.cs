namespace GerenciadorDeComandas
{
    partial class TelaProduto
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.grbInserir = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txbPrecoInse = new System.Windows.Forms.TextBox();
            this.txbNomeProdutoInse = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.grbModificar = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txbPrecoModi = new System.Windows.Forms.TextBox();
            this.txbNomeModi = new System.Windows.Forms.TextBox();
            this.lblPrecoModi = new System.Windows.Forms.Label();
            this.lblNomeModi = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbInserir.SuspendLayout();
            this.grbModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(35, 30);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(458, 231);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // grbInserir
            // 
            this.grbInserir.Controls.Add(this.lblCategoria);
            this.grbInserir.Controls.Add(this.cmbCategoria);
            this.grbInserir.Controls.Add(this.btnInserir);
            this.grbInserir.Controls.Add(this.txbPrecoInse);
            this.grbInserir.Controls.Add(this.txbNomeProdutoInse);
            this.grbInserir.Controls.Add(this.lblPreco);
            this.grbInserir.Controls.Add(this.lblNomeProduto);
            this.grbInserir.Location = new System.Drawing.Point(35, 297);
            this.grbInserir.Name = "grbInserir";
            this.grbInserir.Size = new System.Drawing.Size(222, 154);
            this.grbInserir.TabIndex = 1;
            this.grbInserir.TabStop = false;
            this.grbInserir.Text = "Inserir Produto:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(63, 110);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(96, 38);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txbPrecoInse
            // 
            this.txbPrecoInse.Location = new System.Drawing.Point(107, 59);
            this.txbPrecoInse.Name = "txbPrecoInse";
            this.txbPrecoInse.Size = new System.Drawing.Size(94, 20);
            this.txbPrecoInse.TabIndex = 3;
            // 
            // txbNomeProdutoInse
            // 
            this.txbNomeProdutoInse.Location = new System.Drawing.Point(107, 33);
            this.txbNomeProdutoInse.Name = "txbNomeProdutoInse";
            this.txbNomeProdutoInse.Size = new System.Drawing.Size(94, 20);
            this.txbNomeProdutoInse.TabIndex = 2;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(60, 62);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(41, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço: ";
            this.lblPreco.Click += new System.EventHandler(this.lblPreco_Click);
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(6, 36);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(95, 13);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome Do Produto:";
            // 
            // grbModificar
            // 
            this.grbModificar.Controls.Add(this.btnModificar);
            this.grbModificar.Controls.Add(this.txbPrecoModi);
            this.grbModificar.Controls.Add(this.txbNomeModi);
            this.grbModificar.Controls.Add(this.lblPrecoModi);
            this.grbModificar.Controls.Add(this.lblNomeModi);
            this.grbModificar.Location = new System.Drawing.Point(271, 297);
            this.grbModificar.Name = "grbModificar";
            this.grbModificar.Size = new System.Drawing.Size(222, 154);
            this.grbModificar.TabIndex = 5;
            this.grbModificar.TabStop = false;
            this.grbModificar.Text = "Modificar Produto:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(63, 110);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 38);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txbPrecoModi
            // 
            this.txbPrecoModi.Location = new System.Drawing.Point(107, 59);
            this.txbPrecoModi.Name = "txbPrecoModi";
            this.txbPrecoModi.Size = new System.Drawing.Size(94, 20);
            this.txbPrecoModi.TabIndex = 3;
            // 
            // txbNomeModi
            // 
            this.txbNomeModi.Location = new System.Drawing.Point(107, 33);
            this.txbNomeModi.Name = "txbNomeModi";
            this.txbNomeModi.Size = new System.Drawing.Size(94, 20);
            this.txbNomeModi.TabIndex = 2;
            // 
            // lblPrecoModi
            // 
            this.lblPrecoModi.AutoSize = true;
            this.lblPrecoModi.Location = new System.Drawing.Point(60, 62);
            this.lblPrecoModi.Name = "lblPrecoModi";
            this.lblPrecoModi.Size = new System.Drawing.Size(41, 13);
            this.lblPrecoModi.TabIndex = 1;
            this.lblPrecoModi.Text = "Preço: ";
            // 
            // lblNomeModi
            // 
            this.lblNomeModi.AutoSize = true;
            this.lblNomeModi.Location = new System.Drawing.Point(6, 36);
            this.lblNomeModi.Name = "lblNomeModi";
            this.lblNomeModi.Size = new System.Drawing.Size(95, 13);
            this.lblNomeModi.TabIndex = 0;
            this.lblNomeModi.Text = "Nome Do Produto:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(107, 86);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(94, 21);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(49, 89);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 491);
            this.Controls.Add(this.grbModificar);
            this.Controls.Add(this.grbInserir);
            this.Controls.Add(this.dgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbInserir.ResumeLayout(false);
            this.grbInserir.PerformLayout();
            this.grbModificar.ResumeLayout(false);
            this.grbModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grbInserir;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TextBox txbPrecoInse;
        private System.Windows.Forms.TextBox txbNomeProdutoInse;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox grbModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txbPrecoModi;
        private System.Windows.Forms.TextBox txbNomeModi;
        private System.Windows.Forms.Label lblPrecoModi;
        private System.Windows.Forms.Label lblNomeModi;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}