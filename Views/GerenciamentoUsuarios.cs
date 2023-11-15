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
    public partial class GerenciamentoUsuarios : Form
    {

        //Variável Global
        int IdSelecionado = 0;

        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void pcbSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
   
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Instanciar o usuario:
            Classes.Usuario usuario = new Classes.Usuario();

            usuario.NomeCompleto = txbNomeCad.Text;
            usuario.Email = txbEmailCad.Text;
            usuario.Senha = txbSenhaCad.Text;

            if (usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!!");
                //Limpar os campos:
                txbNomeCad.Clear();
                txbEmailCad.Clear();
                txbSenhaCad.Clear();

                //Atualizar Tabela:
                dgvUsuarios.DataSource = usuario.ListarTudo();
            }
            else
            {

                MessageBox.Show("Falha ao cadastrar usuario");

            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = IdSelecionado;
            usuario.NomeCompleto = txbNomeEdi.Text;
            usuario.Email = txbEmailEdi.Text;
            usuario.Senha = txbSenhaEdi.Text;

            if (usuario.Editar() == true)
            {
                MessageBox.Show("Usuário editado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpar os campos:
                txbNomeEdi.Clear();
                txbEmailEdi.Clear();
                txbSenhaEdi.Clear();

                //Atualizar Tabela:
                dgvUsuarios.DataSource = usuario.ListarTudo();

                //Atualizar Tabela:
                dgvUsuarios.DataSource = usuario.ListarTudo();

                lblApagar.Text = "Selecione um usuário para apagar!";

                //Desabilitar grbs:
                grbApagar.Enabled = false;
                grbEditar.Enabled = false;
            }
            else
            {

                MessageBox.Show("Falha ao editar usuario", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ativar os grb(GroupBox):
            grbEditar.Enabled = true;
            grbApagar.Enabled = true;

            //Obter a linha:
            int linhaselecionada = dgvUsuarios.CurrentCell.RowIndex;

            //Armazenar os dados da linha selecionada:
            var linha = dgvUsuarios.Rows[linhaselecionada];

            txbNomeEdi.Text =  linha.Cells[1].Value.ToString();
            txbEmailEdi.Text = linha.Cells[2].Value.ToString();


            //Exibir ID e Nome para apagar
            lblApagar.Text = "Deseja apagar: " + linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            //Armazenar ID selecionado na variavel global:
            IdSelecionado = (int)linha.Cells[0].Value;


        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            
            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = IdSelecionado;
            //Remover:

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuário removido","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    //Limpar os campos:
                    txbNomeEdi.Clear();
                    txbEmailEdi.Clear();
                    txbSenhaEdi.Clear();

                    //Atualizar Tabela:
                    dgvUsuarios.DataSource = usuario.ListarTudo();

                    lblApagar.Text = "Selecione um usuário para apagar!";

                    //Desabilitar grbs:
                    grbApagar.Enabled = false;
                    grbEditar.Enabled = false;
                }
                else
                {

                    MessageBox.Show("Falha ao remover usuario", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }


        }
    }
}
