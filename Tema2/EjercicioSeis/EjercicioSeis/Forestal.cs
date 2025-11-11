using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSeis
{
    public class Forestal
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }

        public Forestal(string nombre, string apellido1, string apellido2, string telefono)
        {
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Telefono = telefono;
        }
        public Forestal()
        { 
        }
        public override string ToString()
        {
            return Nombre + " " + Apellido1;
        }
    }
}
