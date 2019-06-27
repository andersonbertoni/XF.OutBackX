using System;
using System.Collections.Generic;
using System.Text;

namespace XF.OutBackX.Model
{
    public class RestauranteModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
