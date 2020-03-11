using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patron2
{
    public class SatuSerState : SerState
    {
        public override void Respuesta()
        {
            Task.Delay(500);
            Console.WriteLine("Respuesta 200 con un Delay de 500");
        }
    }
    
}
