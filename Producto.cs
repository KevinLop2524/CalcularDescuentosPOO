using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularDescuentosPOO
{
    public class Producto
    {
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public string tipo { get; set; }

        public Producto(string nombre, decimal precio, string tipo)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.tipo = tipo;
        }

        public Producto() {}


        /*public decimal CalcularDescuento(decimal precio, string tipo)
        {
            try
            {
  

                switch (tipo)
                {
                    case "Tecnologia":
                        decimal resultado = (10 * precio) / 100;
                        return resultado;
                    case "Alimento":
                        decimal resultado2 = (2 * precio) / 100;
                        return resultado2;
                    case "General":
                        decimal resultado3 = (5 * precio) / 100;
                        return resultado3;

                    default:
                        MessageBox.Show("Opción no valida");
                        return 0;
                }


            }
            catch {  return 0; };
        }*/

        public virtual decimal CalcularDescuento(decimal precio)
        {
            decimal resultado = precio * 0.05m;
            return resultado;

        }
    }
}
