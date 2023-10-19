using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// esta clase no cumple con el principio de responsabilidad única ya que mezcla la funcionalidad de modelo de clase con la funcionalidad de guardar un coche en la BBDD
// serían dos funcionalidades distintas, lo correcto sería hacer una clase modelo y una clase de acceso a datos

namespace PrincipiosSolid.SingleResponsability.Incorrecto
{
    public class Coche
    {
        String marca;
       
        Coche(string marca) { this.marca = marca; }
       
        String getMarcaCoche() { return marca; }

        void guardarCocheDB(Coche coche)
        {

        }
    }
}
