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
    public partial class MenuPrincipal : Form
    {

        //Objetos globais:
        Classes.Usuario usuario= new Classes.Usuario();
        Classes.Produto produto= new Classes.Produto();









        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            //Mudar lbl de saudação:

            lblSaudacao.Text = "Olá " + usuario.NomeCompleto;
           
        }

        public MenuPrincipal(Classes.Produto produto)
        {
            InitializeComponent();
            this.produto = produto;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }




        //Abrir Janela Usuários:
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //Instanciar janela usuarios:

            Views.GerenciamentoUsuarios janela = new Views.GerenciamentoUsuarios();
            janela.Show();
        }




        //Abrir Janela Produtos:
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            //Instanciar janela produtos:
          

            TelaProduto janelap = new TelaProduto(usuario);
            janelap.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnComandas_Click(object sender, EventArgs e)
        {
            Views.GerenciadorComandas janela = new Views.GerenciadorComandas(usuario);
            janela.Show();

        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            //Instanciar janela Caixa:

            Views.Caixa janela = new Views.Caixa(usuario);
            janela.Show();
        }
    }
}
