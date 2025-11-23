using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularDescuentosPOO
{
    public class Utilidades
    {
        public decimal LeerTexto(string texto)
        {
            if (texto == null || texto == "") return 0; else return 1;
        }
        public decimal LeerDecimal(string texto)
        {
            decimal valor;

           if(!decimal.TryParse(texto, out valor))
            {
                return -1;

            }else return valor;
        }
    }
}
