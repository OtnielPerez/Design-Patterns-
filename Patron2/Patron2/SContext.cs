using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patron2
{
    public class SContext
    {
        private SerState state;

        public SerState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public void AtenderSolicitud()
        {
            state.Respuesta();

        }

    }
}
