using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularDescuentosPOO
{
    public partial class Form1 : Form
    {

        public Producto producto;
        public Utilidades utilidades = new Utilidades();


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {

            string nombre = NombreProducto.Text;
            string precio = PrecioProducto.Text;
            string tipo = TipoProducto.Text;

            decimal ResultadoNombre= utilidades.LeerTexto(nombre);
            decimal ResultadoTipo = utilidades.LeerTexto(tipo);

            if(ResultadoNombre == 0 || ResultadoTipo == 0)
            {
                MessageBox.Show("Tipo de dato no valido en nombre o tipo");
                return;
            }

            decimal precio_real = utilidades.LeerDecimal(precio);
            if (precio_real < 0)
            {
                MessageBox.Show("Tipo de dato no valido en precio");
                return;
            }
            
            this.producto= new Producto(nombre, precio_real, tipo);


            decimal resultado = this.producto.CalcularDescuento(precio_real, tipo);
            MessageBox.Show($"Total: {resultado:c}$");


        }
    }
}

