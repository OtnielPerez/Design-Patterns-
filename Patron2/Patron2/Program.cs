using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Patron2
{
    public class Program
    {
        /*Patron de diseño State se usa para administrar como se deben comportar nuestros
        objetos dependiendo el estado de los mismos*/

        public static void Main(string[] args)
        {
            SContext oServidor = new SContext();
            oServidor.State = new DisponibleSerState();

            oServidor.AtenderSolicitud();

            oServidor.State = new SatuSerState();
            oServidor.AtenderSolicitud();
            oServidor.AtenderSolicitud();

            oServidor.State = new SuperSatuSerState();
            oServidor.AtenderSolicitud();
            oServidor.AtenderSolicitud();

            oServidor.State = new ServidorCaidoState();
            oServidor.AtenderSolicitud();
            oServidor.AtenderSolicitud();

            oServidor.State = new DisponibleSerState();
            oServidor.AtenderSolicitud();
            oServidor.AtenderSolicitud();
        }

        
    }
}
