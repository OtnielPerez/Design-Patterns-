using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patron3_Prototype
{
    public class uanimal : ICloneable
    {
        public int patas { get; set; }
        public string nombre { get; set; }

        public atributos rasgos { get; set; }


        public object Clone() 
        {


            return this.MemberwiseClone() as uanimal;
        }
    }

    public class atributos
    {
        public string Color { get; set; }
        public string Raza { get; set; }
    }
}
