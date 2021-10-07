using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGM_FORMS.Model
{
    public class Ocorrencia
    {
        public int idOCORRENCIA { get; set; }
        public string NUMERO { get; set; }
        public string DATA { get; set; }
        public double VALOR { get; set; }
        public int TERCEIRO_idTERCEIRO { get; set; }
        public int DOCUMENTO_idDOCUMENTO { get; set; }
        public int DESCRICAO_idDESCRICAO { get; set; }
        public int ACORDO_idACORDO { get; set; }
        public int AJUIZADO_idAJUIZADO { get; set; }
    }
}


