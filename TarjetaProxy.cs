using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Clases
{
    public class TarjetaProxy : Tarjeta
    {
        // Referencia a la tarjeta original
        private Tarjeta tarjetaOriginal;

        // Constructor en el que se inyectará el objeto real
        public TarjetaProxy(Tarjeta tarjeta)
        {
            tarjetaOriginal = tarjeta;
        }

        // Este método realizará el control de acceso sobre el método original.
        // Realizará una comprobación previa comparando el código de seguridad y, si este es
        // correcto, invocará el método del objeto real.
        public override void RealizarContacto(Central central)
        {
            // Realizamos una comprobación adicional de seguridad. En caso de no cumplirse, se
            // aborta la operación. Esta operación podría ser la ejecución de un algoritmo para
            // comprobar la autenticidad del código de la , una comprobación de nombre de
            // usuario y contraseña... o cualquier otra comprobación que queramos realizar.
            if (central.CodigoSeguridad > tarjetaOriginal.Codigotarjeta.ToString().GetHashCode())
            {
                Console.WriteLine("Código de seguridad incorrecto. Puerta no abierta");
                return;
            }

            if (tarjetaCorrecta(central.Codigotarjeta))
                Console.WriteLine("Contacto realizado");
            else
                Console.WriteLine("Código de la tarjeta inválido");
        }

        // Este método no realizará comprobaciones adicionales. Se limitará a invocar el método
        // del objeto real.
        public override bool tarjetaCorrecta(int codigotarjeta)
        {
            return tarjetaOriginal.tarjetaCorrecta(codigotarjeta);
        }
    }
}

