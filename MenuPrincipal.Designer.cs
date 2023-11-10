namespace GerenciadorDeComandas
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
            this.btnComandas = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComandas
            // 
            this.btnComandas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComandas.Location = new System.Drawing.Point(76, 175);
            this.btnComandas.Name = "btnComandas";
            this.btnComandas.Size = new System.Drawing.Size(236, 40);
            this.btnComandas.TabIndex = 0;
            this.btnComandas.Text = "Comandas";
            this.btnComandas.UseVisualStyleBackColor = true;
            // 
            // btnProdutos
            // 
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProdutos.Location = new System.Drawing.Point(76, 221);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(236, 40);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnCaixa
            // 
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaixa.Location = new System.Drawing.Point(76, 267);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(236, 40);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUsuarios.Location = new System.Drawing.Point(76, 313);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(236, 40);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(73, 159);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Qual opção você deseja? :";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(130, 65);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(126, 20);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu Principal";
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Location = new System.Drawing.Point(73, 146);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(0, 13);
            this.lblSaudacao.TabIndex = 6;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 427);
            this.Controls.Add(this.lblSaudacao);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnComandas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblSaudacao;
    }
}