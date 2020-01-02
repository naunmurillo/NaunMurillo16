using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Clases
{
   public abstract class TarjetaReal : Tarjeta
    {
        // Constructor base: asigna el código de la tarjeta a la tarjeta
    public TarjetaReal(int codigotarjeta)
        {
            this.codigotarjeta = codigotarjeta;
        }

        // Realizar contacto: comprueba que el código de la tarjeta sea correcto.
        // En caso de que lo sea, abre la puerta.
        public override void RealizarContacto(Central central)
        {
            if (tarjetaCorrecta(central.Codigotarjeta))
                Console.WriteLine("Contacto realizado");
            else
                Console.WriteLine("Código de tarjeta inválido");
        }

        // Comprueba que el código proporcionado coincide con el de la tarjeta
        public override bool tarjetaCorrecta(int codigotarjeta)
        {
            return codigotarjeta == this.codigotarjeta;
        }
    }
}
