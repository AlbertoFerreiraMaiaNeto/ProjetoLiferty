using ProjetoLifety.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLifety.Model
{
    class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool acessar(string email, string senha)
        {
            loginDaoComandos loginDao = new loginDaoComandos();
            tem = loginDao.verificarLogin(email, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public string cadastrar(string email, string nome, string senha, string confSenha, string especialidade)
        {
            loginDaoComandos loginDao = new loginDaoComandos();
            this.mensagem = loginDao.Cadastrar(email, nome, senha, confSenha, especialidade);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
