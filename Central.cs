using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Clases
{
    class Central
    {
        //definimos el atributo para el código de la tarjeta
        private int codigotarjeta;

        public int Codigotarjeta
        {
            get { return codigotarjeta; }
            set { codigotarjeta = value; }
        }
        //definimos el atributo para el código de seguridad
        private int codigoSeguridad;

        public int CodigoSeguridad
        {
            get { return codigoSeguridad; }
            set { codigoSeguridad = value; }
        }
        public Central(int codigoLlave, int codigoSeguridad)
        {
            // se referencia la instancia de codigotarjeta
            this.codigotarjeta = codigotarjeta;
            // se referencia la instancia de codigoseguridad
            this.codigoSeguridad = codigoSeguridad;
        }

    }
}
