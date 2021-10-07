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
        public static bool InsereTerceiro(int status,string nome, string CPF, string CNPJ, string CNH, string RENAVAM, string EMAIL, string TELEFONE, string CEP)
        {
            return OcorrenciaDB.InsereTerceiro(status,nome,CPF,CNPJ,CNH,RENAVAM,EMAIL,TELEFONE,CEP);
        }
        public static bool ConfereCpf(string terceiro,string cpf)
        {
            if (OcorrenciaDB.ConfereCPF(terceiro) == cpf)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool InsereOcorrencia(string numero, string data, double valor, int status,string nome, string cpf, string CNPJ, string CNH, string RENAVAM, string EMAIL, string TELEFONE, string CEP)
        {

            return OcorrenciaDB.InsereOcorrencia(numero,data,valor,status,nome,cpf,CNPJ,CNH,RENAVAM,EMAIL,TELEFONE,CEP);
        }
        public static List<string[]> SelecionaOcorrencia()
        {
            List<string[]> lista = OcorrenciaDB.SelecionaOcorrencia();
            return lista;
        }
    }
}
