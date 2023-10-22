using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosedPrinciple.Incorrecto
{
    public class Coche
    {
        String marca;
        Coche(String marca) { this.marca = marca; }
        String getMarcaCoche() { return marca; }

        public static void main(String[] args)
        {
            Coche[] arrayCoches =
            {
            new Coche("Renault"),
            new Coche("Audi"),
            new Coche("Mercedes")
            };
            imprimirPrecioMedioCoche(arrayCoches);
        }

        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches) {
                if (coche.marca == "Renault") Console.WriteLine(18000);
                if (coche.marca == "Audi") Console.WriteLine(25000);
                if (coche.marca == "Mercedes") Console.WriteLine(27000);

            }
        }
    }
}

