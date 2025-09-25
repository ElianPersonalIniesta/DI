using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCinco
{
    public class MultiploCinco
    {
        /// <summary>
        /// Metodo que comprueba si un numero es múltiplo de 5
        /// </summary>
        /// <param name="num">Numero a comparar</param>
        /// <returns>True si es Multiplo, False si no es multiplo</returns>
        public  bool EsMultiploCinco(int num)
        {
            if (num % 5 == 0)
            {
                Console.WriteLine("Es multiplo");
                return true;
            }
            else
            {
                Console.WriteLine("No es Multiplo");
                return false;
            }
        }
    }
}
