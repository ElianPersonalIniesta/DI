using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasosDeMensajes
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public Persona(string nombre, int edad, Coche coche) 
        {
            this.Nombre = nombre; 
            this.Edad = edad; 
        }
        public override string ToString() 
        {
            return "Mi nombre es " + this.Nombre + " y tengo " + this.Edad + " años";
        }
        public void cambioEdad(int edadNueva)
        {
            this.Edad = edadNueva;
        }
    }
}
