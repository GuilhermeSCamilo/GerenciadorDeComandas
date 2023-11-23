namespace GerenciadorDeComandas.Views
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.btnListar = new System.Windows.Forms.Button();
            this.txbNumeroComanda = new System.Windows.Forms.TextBox();
            this.lblNumeroComanda = new System.Windows.Forms.Label();
            this.dgvComandas = new System.Windows.Forms.DataGridView();
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.chbConfirmar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(48, 79);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 38);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txbNumeroComanda
            // 
            this.txbNumeroComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumeroComanda.Location = new System.Drawing.Point(48, 35);
            this.txbNumeroComanda.Name = "txbNumeroComanda";
            this.txbNumeroComanda.Size = new System.Drawing.Size(100, 38);
            this.txbNumeroComanda.TabIndex = 1;
            // 
            // lblNumeroComanda
            // 
            this.lblNumeroComanda.AutoSize = true;
            this.lblNumeroComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroComanda.Location = new System.Drawing.Point(44, 12);
            this.lblNumeroComanda.Name = "lblNumeroComanda";
            this.lblNumeroComanda.Size = new System.Drawing.Size(114, 20);
            this.lblNumeroComanda.TabIndex = 2;
            this.lblNumeroComanda.Text = "Nº Comanda:";
            // 
            // dgvComandas
            // 
            this.dgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComandas.Location = new System.Drawing.Point(164, 12);
            this.dgvComandas.Name = "dgvComandas";
            this.dgvComandas.Size = new System.Drawing.Size(417, 256);
            this.dgvComandas.TabIndex = 3;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(45, 180);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(0, 13);
            this.lblPreco.TabIndex = 4;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Location = new System.Drawing.Point(48, 228);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(100, 40);
            this.btnEncerrar.TabIndex = 5;
            this.btnEncerrar.Text = "Fechar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // chbConfirmar
            // 
            this.chbConfirmar.AutoSize = true;
            this.chbConfirmar.Location = new System.Drawing.Point(29, 205);
            this.chbConfirmar.Name = "chbConfirmar";
            this.chbConfirmar.Size = new System.Drawing.Size(129, 17);
            this.chbConfirmar.TabIndex = 6;
            this.chbConfirmar.Text = "Pagamento Recebido";
            this.chbConfirmar.UseVisualStyleBackColor = true;
            this.chbConfirmar.CheckedChanged += new System.EventHandler(this.chbConfirmar_CheckedChanged);
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 285);
            this.Controls.Add(this.chbConfirmar);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.dgvComandas);
            this.Controls.Add(this.lblNumeroComanda);
            this.Controls.Add(this.txbNumeroComanda);
            this.Controls.Add(this.btnListar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txbNumeroComanda;
        private System.Windows.Forms.Label lblNumeroComanda;
        private System.Windows.Forms.DataGridView dgvComandas;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.CheckBox chbConfirmar;
    }
}