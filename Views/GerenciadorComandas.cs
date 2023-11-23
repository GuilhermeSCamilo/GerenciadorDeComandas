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
    public partial class GerenciadorComandas : Form
    {
        //Globais:
        Classes.Usuario usuario;

        public GerenciadorComandas(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.Text = "Gerenciamento Comandas - Logado Como: " + 
                usuario.NomeCompleto.ToUpper();


            //Popular DGV com tabela produtos:
            Classes.Produto produto = new Classes.Produto();
            dgvComandas.DataSource = produto.ListarProduto();

        }

        private void dgvComandas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Obter a linha:
            int linhaselecionada = dgvComandas.CurrentCell.RowIndex;

            //Armazenar os dados da linha selecionada:
            var linha = dgvComandas.Rows[linhaselecionada];

           
            //Popular txb's
            txbCodProduto.Text = linha.Cells[0].Value.ToString();
            txbProdutoInfo.Text = linha.Cells[1].Value.ToString();


        }

        private void GerenciadorComandas_Load(object sender, EventArgs e)
        {

        }


       






        private void btnLancar_Click(object sender, EventArgs e)
        {

            if (txbQuantidade.Text != "")
            {
                var r = MessageBox.Show("Tem certeza que deseja lançar?", "Aviso!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes && txbQuantidade.Text != "")
                {

                    Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                    ordem.IdFicha = int.Parse(txbComanda.Text);
                    ordem.IdProduto = int.Parse(txbCodProduto.Text);
                    ordem.Quantidade = int.Parse(txbQuantidade.Text);
                    ordem.IdResp = usuario.Id;
                    //Efetuar o cadastro:
                    if (ordem.NovoLancamento() == true)
                    {

                        MessageBox.Show("Lançamento efetuado!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();

                    }
                    else
                    {

                        MessageBox.Show("Falha no lançamento !", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpar();

                    }


                }

                MessageBox.Show("Informe a quantidade!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Limpar()
        {


            txbCodProduto.Clear();
            txbComanda.Clear();
            txbProdutoInfo.Clear();
            txbQuantidade.Clear();

            grbInformacoes.Enabled = true;
            grbLancamento.Enabled = false;




        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txbComanda.Text != "" && txbCodProduto.Text != "")
            {
                grbInformacoes.Enabled = true;
                grbLancamento.Enabled = true;

            }
            else 
            {

                MessageBox.Show("Verifique as informações digitadas!!", "Erro", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 

            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
