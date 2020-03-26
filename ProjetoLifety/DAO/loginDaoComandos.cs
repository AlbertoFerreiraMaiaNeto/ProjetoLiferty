using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLifety.DAO
{
    class loginDaoComandos
    {
        public bool tem;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Connection con = new Connection();
        SqlDataReader dr;
        public bool verificarLogin(string email, string senha)
        {
            //COMANDOS SQL PARA VERIFICAR SE TEM NO BANCO
            cmd.CommandText = "select * from Medicos where email = @email and senha =@senha";
            cmd.Parameters.AddWithValue(@"email", email);
            cmd.Parameters.AddWithValue(@"senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;

        }

        public string Cadastrar(string email, string nome, string senha, string confSenha, string especialidade)
        {
            tem = false;

            //COMANDOS PARA INSERIR NO BANCO E RETORNAR MENSAGEM
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into Medicos values(@e,@n,@s,@p);";
                cmd.Parameters.AddWithValue(@"e", email);
                cmd.Parameters.AddWithValue(@"n", nome);
                cmd.Parameters.AddWithValue(@"s", senha);
                cmd.Parameters.AddWithValue(@"p", especialidade);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com Sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem.";
            }
            return mensagem;
        }
    }
}
