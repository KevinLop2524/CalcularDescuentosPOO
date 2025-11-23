using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDescuentosPOO
{
    internal class Tecnologia : Producto
    {
       public override decimal CalcularDescuento(decimal precio)
        {
            decimal resultado;
            resultado = precio * 0.5m;
            return resultado;
        }
    }
}
