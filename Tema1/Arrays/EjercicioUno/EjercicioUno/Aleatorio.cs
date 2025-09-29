using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUno
{
    public class Aleatorio
    {
        /// <summary>
        /// Metodo 
        /// </summary>
        /// <returns></returns>
        public static int numAleatorio()
        {
            Random rnd = new Random();
            return rnd.Next(1,51);
        }
    }
}
