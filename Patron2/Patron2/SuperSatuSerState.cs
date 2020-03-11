using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patron2
{
    public class SuperSatuSerState : SerState
    {
        public override void Respuesta()
        {
            Task.Delay(1000);
            Console.WriteLine("Respuesta 200 con un Delay de 1000");
        }
    }
}
