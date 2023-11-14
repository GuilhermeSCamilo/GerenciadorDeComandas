namespace GerenciadorDeComandas.Views
{
    partial class GerenciamentoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grbCadastro = new System.Windows.Forms.GroupBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.txbSenhaCad = new System.Windows.Forms.TextBox();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txbSenhaEdi = new System.Windows.Forms.TextBox();
            this.txbEmailEdi = new System.Windows.Forms.TextBox();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblSenhaEdi = new System.Windows.Forms.Label();
            this.lblEmailEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblApagar = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grbCadastro.SuspendLayout();
            this.grbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(282, 44);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(253, 303);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // grbCadastro
            // 
            this.grbCadastro.Controls.Add(this.txbSenhaCad);
            this.grbCadastro.Controls.Add(this.txbEmailCad);
            this.grbCadastro.Controls.Add(this.txbNomeCad);
            this.grbCadastro.Controls.Add(this.btnCadastrar);
            this.grbCadastro.Controls.Add(this.lblSenhaCad);
            this.grbCadastro.Controls.Add(this.lblEmailCad);
            this.grbCadastro.Controls.Add(this.lblNomeCad);
            this.grbCadastro.Location = new System.Drawing.Point(35, 44);
            this.grbCadastro.Name = "grbCadastro";
            this.grbCadastro.Size = new System.Drawing.Size(200, 141);
            this.grbCadastro.TabIndex = 1;
            this.grbCadastro.TabStop = false;
            this.grbCadastro.Text = "Cadastro";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(6, 26);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCad.TabIndex = 0;
            this.lblNomeCad.Text = "Nome Completo:";
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(6, 50);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 1;
            this.lblEmailCad.Text = "Email:";
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(6, 75);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCad.TabIndex = 2;
            this.lblSenhaCad.Text = "Senha:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(22, 102);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(159, 33);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(98, 26);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(83, 20);
            this.txbNomeCad.TabIndex = 4;
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(98, 52);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(83, 20);
            this.txbEmailCad.TabIndex = 5;
            // 
            // txbSenhaCad
            // 
            this.txbSenhaCad.Location = new System.Drawing.Point(98, 76);
            this.txbSenhaCad.Name = "txbSenhaCad";
            this.txbSenhaCad.Size = new System.Drawing.Size(83, 20);
            this.txbSenhaCad.TabIndex = 6;
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.txbSenhaEdi);
            this.grbEditar.Controls.Add(this.txbEmailEdi);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Controls.Add(this.lblSenhaEdi);
            this.grbEditar.Controls.Add(this.lblEmailEdi);
            this.grbEditar.Controls.Add(this.lblNomeEdi);
            this.grbEditar.Enabled = false;
            this.grbEditar.Location = new System.Drawing.Point(35, 206);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(200, 141);
            this.grbEditar.TabIndex = 7;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar";
            // 
            // txbSenhaEdi
            // 
            this.txbSenhaEdi.Location = new System.Drawing.Point(98, 73);
            this.txbSenhaEdi.Name = "txbSenhaEdi";
            this.txbSenhaEdi.Size = new System.Drawing.Size(83, 20);
            this.txbSenhaEdi.TabIndex = 6;
            // 
            // txbEmailEdi
            // 
            this.txbEmailEdi.Location = new System.Drawing.Point(98, 49);
            this.txbEmailEdi.Name = "txbEmailEdi";
            this.txbEmailEdi.Size = new System.Drawing.Size(83, 20);
            this.txbEmailEdi.TabIndex = 5;
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Location = new System.Drawing.Point(98, 23);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(83, 20);
            this.txbNomeEdi.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(22, 102);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(159, 33);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblSenhaEdi
            // 
            this.lblSenhaEdi.AutoSize = true;
            this.lblSenhaEdi.Location = new System.Drawing.Point(6, 75);
            this.lblSenhaEdi.Name = "lblSenhaEdi";
            this.lblSenhaEdi.Size = new System.Drawing.Size(70, 13);
            this.lblSenhaEdi.TabIndex = 2;
            this.lblSenhaEdi.Text = "Nova Senha:";
            // 
            // lblEmailEdi
            // 
            this.lblEmailEdi.AutoSize = true;
            this.lblEmailEdi.Location = new System.Drawing.Point(6, 50);
            this.lblEmailEdi.Name = "lblEmailEdi";
            this.lblEmailEdi.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEdi.TabIndex = 1;
            this.lblEmailEdi.Text = "Email:";
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Location = new System.Drawing.Point(6, 26);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(85, 13);
            this.lblNomeEdi.TabIndex = 0;
            this.lblNomeEdi.Text = "Nome Completo:";
            // 
            // pcbSair
            // 
            this.pcbSair.Image = global::GerenciadorDeComandas.Properties.Resources.exit_to_app_icon_137652;
            this.pcbSair.Location = new System.Drawing.Point(490, 430);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(45, 44);
            this.pcbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSair.TabIndex = 8;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(126, 17);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(247, 24);
            this.lblTítulo.TabIndex = 9;
            this.lblTítulo.Text = "Gerenciamento De Usuários";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.lblApagar);
            this.grbApagar.Enabled = false;
            this.grbApagar.Location = new System.Drawing.Point(35, 364);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(307, 50);
            this.grbApagar.TabIndex = 10;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(7, 20);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(191, 13);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuario que deseja apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.LightGray;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.ForeColor = System.Drawing.Color.Black;
            this.btnApagar.Location = new System.Drawing.Point(224, 15);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 486);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.pcbSair);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciamentoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento De Usuarios";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grbCadastro.ResumeLayout(false);
            this.grbCadastro.PerformLayout();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grbCadastro;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbSenhaCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txbSenhaEdi;
        private System.Windows.Forms.TextBox txbEmailEdi;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblSenhaEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
    }
}