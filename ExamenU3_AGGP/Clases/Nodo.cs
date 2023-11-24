using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3_AGGP.Clases
{
    public class Nodo
    {
        private Persona persona;
        private Nodo siguiente;

        public Persona _persona;
        public Nodo _siguiente;

        public Nodo(Persona personaxd)
        {
            _persona = personaxd;
            _siguiente = null;
        }

    }
}
