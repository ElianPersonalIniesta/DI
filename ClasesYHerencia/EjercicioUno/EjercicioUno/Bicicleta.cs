using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUno
{
    public class Bicicleta : Vehiculo
    {
        private string modalidad = string.Empty;
        public string Disciplina
        {
            get {  
                return modalidad; 
            }
            set {
                if (value == "Montaña" || value == "Carretera") 
                { 
                modalidad = value;
                }
            }
        }
        public override void mostrar()
        {
            Console.WriteLine(color); // si puede acceder porque es protected
        }
    }
}
