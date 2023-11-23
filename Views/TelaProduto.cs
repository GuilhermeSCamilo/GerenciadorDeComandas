﻿using GerenciadorDeComandas.Classes;
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
            dgvProdutos1.DataSource = produto.ListarProduto();

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
            //Obter a linha:
            int linhaselecionada = dgvProdutos1.CurrentCell.RowIndex;

            //Armazenar os dados da linha selecionada:
            var linha = dgvProdutos1.Rows[linhaselecionada];

            txbNomeModi.Text = linha.Cells[0].Value.ToString();
            txbPrecoModi.Text = linha.Cells[1].Value.ToString();


            //Instanciar o produto:
            Classes.Produto produto = new Classes.Produto();

            //Atualizar Tabela:
            dgvProdutos1.DataSource = produto.ListarProduto();


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
            produto.IdRespCadastro = 1;





            if (produto.Inserir() == true)
            {


                MessageBox.Show("Produto inserido com sucesso!!");
                //Limpar os campos:
                txbNomeProdutoInse.Clear();
                txbPrecoInse.Clear();

                //Atualizar Tabela:
                dgvProdutos1.DataSource = produto.ListarProduto();
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
                dgvProdutos1.DataSource = produto.ListarProduto();
          

                
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();           
            //Remover:

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuário removido", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar os campos:                  
                    txbPrecoModi.Clear();
                    txbNomeModi.Clear();

                    //Atualizar Tabela:
                    dgvProdutos1.DataSource = produto.ListarProduto();

                    

                    
                }
                else
                {

                    MessageBox.Show("Falha ao remover usuario", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        private void TelaProduto_Load(object sender, EventArgs e)
        {

        }
    }
    }

