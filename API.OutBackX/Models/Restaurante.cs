using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.OutBackX.Models
{
    public class Restaurante
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}