using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GerenciadorDeComandas.Classes
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Preco { get; set; }

        public int IdCategoria { get; set; }

        public int IdRespCadastro { get; set; }


        public DataTable ListarProduto()
        {
            string comando = "SELECT * FROM view_produtos";

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            DataTable tabela = new DataTable();
            MySqlCommand cmd = new MySqlCommand(comando, con);



            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;


        }

        public bool Modificar()
        {
            string comando = "UPDATE produtos SET nome = nome, preco, id_categoria, id_respcadastro";
            //Comando SQL caso senha esteja vazia:
            if (Nome == "")
            {
                comando = "UPDATE produtos SET nome = @nome, preco = @preco, id_categoria = @id_categoria, id_respcadastro = @id_respcadastro WHERE id = @id";

            }

            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_idcategoria", IdCategoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", IdRespCadastro);
            cmd.Prepare();


            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;


            }
        }

        public bool Inserir()
        {

            string comando = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro)" +
                    "VALUES (@nome, @preco, @id_categoria, @id_respcadastro)";
            Banco.ConexaoBanco conexaoBD = new Banco.ConexaoBanco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Nome);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);
            cmd.Parameters.AddWithValue("@id_respcadastro", IdRespCadastro);


            cmd.Prepare();
            
            
            //try
            //{
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            //}
            //catch
            //{
            //    conexaoBD.Desconectar(con);
            //    return false;
            //}


        }

    }


}
