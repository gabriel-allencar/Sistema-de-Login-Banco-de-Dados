using ProjetoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {

        public bool tem;
        public string mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            tem = loginDal.verificarLogin(login, senha);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;  
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            return mensagem;

        }

    }

}
