using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Campo
    {
        public string Identificado { get; set; }
        public Double Superficie { get; set; }

        public Campo(string id,Double sup) 
        {
            Identificado = id;
            Superficie = sup;

        }
    }
}
