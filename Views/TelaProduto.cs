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
        


        public TelaProduto(Classes.Usuario usuario)
        {

            InitializeComponent();
            Classes.Produto produto = new Classes.Produto();
            dgvProdutos.DataSource = produto.ListarProduto();

            InitializeComponent();
            this.usuario = usuario;

            //Mudar lbl de saudação:

            lblLogado.Text = "Logado como: " + usuario.NomeCompleto;
            string logado = usuario.NomeCompleto;

        }

        

        //Instanciar usuario:
        Classes.Usuario usuario = new Classes.Usuario();
        private int logado;

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


            //Instanciar o produto:
            Classes.Produto produto = new Classes.Produto();

            //Atualizar Tabela:
            dgvProdutos.DataSource = produto.ListarProduto();


        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Instanciar o produto:
            Classes.Produto produto = new Classes.Produto();
            produto.Nome = txbNomeProdutoInse.Text;
            produto.Preco = txbPrecoInse.Text;
            produto.IdCategoria = 1;
            

            var resultado = usuario.Logar();
            usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
            usuario.Id = (int)resultado.Rows[0]["id"];
            Classes.Usuario usuarionome = new Classes.Usuario();
            MessageBox.Show("Produto registrado por: " + usuario.NomeCompleto);

            produto.IdRespCadastro = (int)resultado.Rows[0]["id"];





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
                MessageBox.Show("Produto editado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpar os campos:
                txbNomeModi.Clear();
                txbPrecoModi.Clear();
               

                //Atualizar Tabela:
                dgvProdutos.DataSource = produto.ListarProduto();
          

                
            }
            else
            {

                MessageBox.Show("Falha ao editar Produto", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {


           



        }

        private void txbNomeProdutoInse_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

