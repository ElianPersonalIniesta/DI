using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUno
{
     public class Vehiculo
    {
        //ATRIBUTOS
        protected string color; // a este puede acceder cualquier clase que hereda de vehiculo
        private int personas;
        //PROPIEDADES
        public int Ruedas {  get; set; }
        public int MaXPersonas 
        { 
            get => personas; //--> Esto se usa para cuando se va a manipular un ATRIBUTO ya existente
            //{ return personas; }
            set=> personas = value;
            }
        public Vehiculo()
        {
            color = "azul";
            personas = 4;
            Ruedas = 2;
        }
        public Vehiculo(string color, int personas, int ruedas) { 
            this.color = color;
            this.personas = personas;
            this.Ruedas = ruedas;
        }
        public string getColor() {  return color; }
        public void setColor(string color) { this.color = color; }

        public virtual void mostrar() // Para que se pueda sobreescribir tiene que ir con virtual 
        {
            Console.WriteLine("El coche tiene {0} ruedas, un máximo de ocupantes de {1}, " +
                "y es de color {2}",Ruedas, MaXPersonas,getColor());   
        }
        public override bool Equals(Object obj)
        {
            Vehiculo v = (Vehiculo)obj;
            if (this.color == v.getColor() && this.Ruedas==v.Ruedas && this.MaXPersonas==v.MaXPersonas) 
            {  return true; }
            else
            {
                return false;
            }
                
        }
    }
}
