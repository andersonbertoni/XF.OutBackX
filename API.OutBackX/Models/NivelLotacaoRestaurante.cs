using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.OutBackX.Models
{
    public class NivelLotacaoRestaurante
    {
        public int ID { get; set; }
        public int ID_Restaurante { get; set; }
        public NivelLotacao NivelLotacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}