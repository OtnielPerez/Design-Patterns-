using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patron2
{
    public class ServidorCaidoState : SerState
    {
        public override void Respuesta()
        {
            Task.Delay(500);
            Console.WriteLine("Temporalmente no disponible");
        }
    }
}
