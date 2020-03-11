using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patron1
{
    public class Class
    {
        private static Class instance = null;
        public string mensaje = "";

        protected Class() {
            mensaje = "Patron de diseño Singleton";
        }
         
        public static Class Instance
        
        {
            get
            {
                if (instance == null)
                    instance = new Class();

                return instance;
            }
        }
    }
}
