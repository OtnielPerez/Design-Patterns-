using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Patron1
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine(Class.Instance.mensaje);

            Console.WriteLine(Class.Instance.mensaje);
        }
        
    }
}
