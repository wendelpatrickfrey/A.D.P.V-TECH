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
        public static void InsereOcorrencia(int datai, int dataa, string numero, double valor)
        {
            OcorrenciaDB.InsereOcorrencia(datai, dataa, numero, valor);
        }



        public static void InsereCadastro(string usuario, string senha)
        {
            UsuarioDB.InsereCadastro(usuario, senha);
        }

        public static void InsereFuncionario(string nome, string sexo, string funcao, string cpf_cnpj, string celular, string email)
        {
            UsuarioDB.InsereFuncionario(nome, sexo, funcao, cpf_cnpj, celular, email);
        }


        public static bool Login(string usuario, string senha)
        {
            bool temp = false;
            if (!string.IsNullOrEmpty(usuario) && usuario.Length < 51)
            {
                if (!string.IsNullOrEmpty(senha) && senha.Length < 51)
                {
                    temp = UsuarioDB.Login(usuario, senha);
                }
                else
                {
                    return temp;
                }
            }
            else
            {
                return temp;
            }
            return temp;
        }


        //public static bool ConfereUsuario(string usuario)
        //{
        //    string confere = UsuarioDB.SelectUsuario(usuario);
        //    if (usuario != confere)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}
        //public static bool InsereTerceiro(int status, string nome, string CPF, string CNPJ, string CNH, string RENAVAM, string EMAIL, string TELEFONE, string CEP)
        //{
        //    return OcorrenciaDB.InsereTerceiro(status, nome, CPF, CNPJ, CNH, RENAVAM, EMAIL, TELEFONE, CEP);
        //}
        //public static bool ConfereCpf(string terceiro,string cpf)
        //{
        //    if (OcorrenciaDB.ConfereCPF(terceiro) == cpf)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
        //public static bool InsereOcorrencia(string numero, string data, double valor, int status,string nome, string cpf, string CNPJ, string CNH, string RENAVAM, string EMAIL, string TELEFONE, string CEP)
        //{

        //    return OcorrenciaDB.InsereOcorrencia(numero,data,valor,status,nome,cpf,CNPJ,CNH,RENAVAM,EMAIL,TELEFONE,CEP);
        //}
        //public static List<string[]> SelecionaOcorrencia()
        //{
        //    List<string[]> lista = OcorrenciaDB.SelecionaOcorrencia();
        //    return lista;
        //}
    }
}
