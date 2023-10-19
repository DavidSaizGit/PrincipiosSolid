﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosedPrinciple.Incorrecto
{
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
            for (Coche coche : arrayCoches) {
                if (coche.marca.equals("Renault")) System.out.println(18000);
                if (coche.marca.equals("Audi")) System.out.println(25000);
                if (coche.marca.equals("Mercedes")) System.out.println(27000);

            }
        }
    }

