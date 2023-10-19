using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosedPrinciple.Correcto
{

    public static void main(String[] args)
    {
        Coche[] arrayCoches =
        {
            new Renault(),
            new Audi(),
            new Mercedes()
        };

        imprimirPrecioMedioCoche(arrayCoches);
    }
    public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
    {
        for (Coche coche : arrayCoches)
        {
            Console.WriteLine(coche.PrecioMedioCoche());
        }
    }
    
}
