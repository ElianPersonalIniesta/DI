using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDos
{
    public class Persona
    {
        private string nombre;
        private int longitud;
        public string Nombre 
        { get; 
          set; }
        public int Longitud 
        { 
          get 
            { 
                return longitud; 
            }
          set 
            { 
                this.Longitud = value;
            }
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
            this.longitud = nombre.Length;
        }
    }
}
