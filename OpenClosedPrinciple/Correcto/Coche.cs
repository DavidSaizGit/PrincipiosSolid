﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.OpenClosedPrinciple.Correcto
{
    partial class Coche
    {
        String marca;

        Coche(String marca) { this.marca = marca; }

        String getMarcaCoche() { return marca; }

         partial int PrecioMedioCoche();
    }

}
