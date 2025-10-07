using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Persona
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private string nombre;
        private int longitud;
        /// <summary>
        /// Propiedades
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                this.nombre = value;
            }
        }
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
        /// <summary>
        /// Constructor de la clase Persona
        /// </summary>
        /// <param name="nombre"></param>
        public Persona(string nombre)
        {
            this.nombre = nombre;
            this.longitud = nombre.Length;
        }
    }
}
