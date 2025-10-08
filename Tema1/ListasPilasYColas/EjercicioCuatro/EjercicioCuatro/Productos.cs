using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuatro
{
    public class Productos
    {
        ///Atributos
        private int cantidad;
        private double precio;

        ///Constructor
        public Productos(int cantidad, double precio)
        {
            this.cantidad = cantidad;
            this.precio = precio;
        }
        ///Getters y Setters
        public int getCantidad()
        {
            return cantidad;
        }
        public double getPrecio()
        {
            return precio;
        }
        public double precioFinal()
        {
            return Convert.ToDouble(this.precio * this.cantidad);
        }
    }
}
