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

        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            //Mudar lbl de saudação:

            lblSaudacao.Text = "Olá " + usuario.NomeCompleto;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //Instanciar janela

            Views.GerenciamentoUsuarios janela = new Views.GerenciamentoUsuarios();
            janela.Show();
        }
    }
}
