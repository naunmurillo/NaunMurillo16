using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Clases;
namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int codigotarjeta = 532543463;
            int codigoSeguridad = 1038948470;

            Central central = new Central(codigotarjeta, codigoSeguridad);

            Tarjeta tarjetaSimple = new TarjetaReal(codigotarjeta);
            tarjetaSimple.RealizarContacto(central);

            Tarjeta proxy = new TarjetaProxy(tarjetaSimple);
            proxy.RealizarContacto(central);


            Console.ReadKey();
        }


       
    }
}
