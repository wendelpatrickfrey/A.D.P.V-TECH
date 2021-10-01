using BGM_FORMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGM_FORMS.Control
{
    class Controller
    {
        public static bool InsereCadastro(string nome, string usuario, string senha, int funcao)
        {
            return UsuarioDB.InsereCadastro(nome, usuario, senha, funcao);
        }
        public static int Login(string usuario, string senha)
        {
            int funcao = -1;
            if (!string.IsNullOrEmpty(usuario) && usuario.Length < 51)
            {
                if (!string.IsNullOrEmpty(senha) && senha.Length < 51)
                {
                    funcao = UsuarioDB.Login(usuario, senha);
                }
                else
                {
                    return funcao;
                }
            }
            else
            {
                return funcao;
            }
            return funcao;
        }
        public static bool ConfereUsuario(string usuario)
        {
            string confere = UsuarioDB.SelectUsuario(usuario);
            if (usuario != confere)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
