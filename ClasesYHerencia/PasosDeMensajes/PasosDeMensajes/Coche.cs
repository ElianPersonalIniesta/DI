using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasosDeMensajes
{
    public class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public Persona Propietario { get; set; }

        /*public Coche(string marca, string modelo,string color, Persona propietario)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.Propietario = propietario;
        }*/

        public Coche (string marca, string modelo, string color, string nombrePropietario, int edadPropietario)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.Propietario = new Persona (nombrePropietario,edadPropietario,this);
        }

        public void cambioEdadPropietario(int edad)
        {
            Propietario.Edad = edad;
        }
        public override string ToString()
        {
            return "El coche es un " + Marca + " " + Modelo + " de color " + Color + 
                " y es del propietario " + Propietario.Nombre+" que tiene "+ Propietario.Edad+" años";
        }
        public void CambioPropietario(String nombre, int edad)
        {
            this.Propietario=new Persona(nombre,edad,this);
        }
    }
}
