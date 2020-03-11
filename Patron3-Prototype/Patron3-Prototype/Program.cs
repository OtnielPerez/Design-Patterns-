using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Patron3_Prototype
{
    public class Program
        //Prototype Shallow patron de diseño utlizado para clonar objetos
    {
        public static void Main(string[] args)
        {
            uanimal Animal = new uanimal() {nombre = "vaca", patas =4 };
            Animal.rasgos = new atributos();
            Animal.rasgos.Color = "Blanco";
            Animal.rasgos.Raza = "Brahman";

            uanimal uanimalCloned =  Animal.Clone() as uanimal;
            uanimalCloned.rasgos.Color = "Blanco";
            uanimalCloned.nombre = "Vaca Lola";




            Console.WriteLine("Animal Original: "+Animal.rasgos.Color);
            Console.WriteLine("Animal Clonado: " + uanimalCloned.rasgos.Color);
            Console.WriteLine("Animal Original: " + Animal.nombre);
            Console.WriteLine("Animal Clonado: " + uanimalCloned.nombre);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
