using GerenciadorDeComandas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeComandas
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {          

            InitializeComponent();
            Classes.Produto produto = new Classes.Produto();
            dgvProdutos.DataSource = produto.ListarProduto();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obter a linha e armazenar em variável:
            int linhaselecionada = dgvProdutos.CurrentCell.RowIndex;

            //Armazenar os dados da linha selecionada:
            var linha = dgvProdutos.Rows[linhaselecionada];


            //
            txbNomeProdutoInse.Text = linha.Cells[1].Value.ToString();
            txbPrecoInse.Text = linha.Cells[2].Value.ToString();


            //Instanciar o usuario:
            Classes.Produto produto = new Classes.Produto();

            //Atualizar Tabela:
            dgvProdutos.DataSource = produto.ListarProduto();


        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Instanciar o usuario:
            Classes.Produto produto = new Classes.Produto();


            produto.Nome = txbNomeProdutoInse.Text;
            produto.Preco = txbPrecoInse.Text;
            produto.IdCategoria = 1;
            produto.IdRespCadastro = 1;


            if (produto.Inserir() == true)
            {


                MessageBox.Show("Produto inserido com sucesso!!");
                //Limpar os campos:
                txbNomeProdutoInse.Clear();
                txbPrecoInse.Clear();

                //Atualizar Tabela:
                dgvProdutos.DataSource = produto.ListarProduto();
            }
            else
            {

                MessageBox.Show("Falha ao inserir produto");

            }
           

            


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            Classes.Produto produto = new Classes.Produto();
            
            produto.Nome = txbNomeModi.Text;
            produto.Preco = txbPrecoModi.Text;
            

            if (produto.Modificar() == true)
            {
                MessageBox.Show("Usuário editado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpar os campos:
                txbNomeModi.Clear();
                txbPrecoModi.Clear();
               

                //Atualizar Tabela:
                dgvProdutos.DataSource = produto.ListarProduto();
          

                
            }
            else
            {

                MessageBox.Show("Falha ao editar usuario", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

