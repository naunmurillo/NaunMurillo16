using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Clases
{
    
        // Clase abstracta de la que heredará el elemento original y el proxy
        public abstract class Tarjeta
        {
            // Código de la tarjeta
            protected int codigotarjeta;

            // Propiedad de sólo lectura para obtener el código de la tarjeta
            public int Codigotarjeta
            {
                get { return codigotarjeta; }
            }

            // Métodos abstractos que implementarán el elemento real y el proxy
            public abstract void RealizarContacto(Central central);
            public abstract bool tarjetaCorrecta(int codigotarjeta);
        }
    }

