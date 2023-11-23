using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeComandas.Views
{
    public partial class Caixa : Form
    {

        //Globais:
        Classes.Usuario usuario;
        public Caixa(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Caixa_Load(object sender, EventArgs e)
        {

        }

        private void chbConfirmar_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrar.Enabled = chbConfirmar.Checked;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (txbNumeroComanda.Text != "")

            {

                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbNumeroComanda.Text);
                var r = ordem.BuscarFicha();
                dgvComandas.DataSource = r;

                lblPreco.Text = "R$ "+ r.Compute("SUM(Total_Item)", "True").ToString();

            }
            else
            {
                MessageBox.Show("Digite o numero da ficha!!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja encerrar?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {

                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbNumeroComanda.Text);
                if (ordem.EncerrarFicha() == true)
                {

                    MessageBox.Show("Ficha encerrada!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("Falha ao encerrar a ficha!", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
