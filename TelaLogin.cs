using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeComandas
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Instanciar usuário:

            Classes.Usuario usuario= new Classes.Usuario();

            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;


            //Obter o resultado do select no banco:
            var resultado = usuario.Logar();

            

            if (resultado.Rows.Count == 1)
            {

                usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                usuario.Id = (int)resultado.Rows[0]["id"];
                MessageBox.Show(usuario.NomeCompleto);
                
                //Abrir a janela menu:
                MenuPrincipal janela = new MenuPrincipal();

                Hide();
                //Mostrar menu:
                janela.ShowDialog();
                //Mostrar login:
                Show();
            
            }
            else 
            {

                MessageBox.Show("Email ou senha incorretos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }




        }
    }
}
