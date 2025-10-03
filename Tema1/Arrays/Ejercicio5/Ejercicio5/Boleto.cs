using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Boleto
    {
        private int[] combinacion = new int[6];
        //que no se repita los numeros (while????)

        public Boleto()
        {
            //aqui deberíamos poner un boleto que YA tenga el numero para no llamar a creacionBoleto dentro de app.cs
        }

        public void creacionBoleto()
        {
            bool comprobante = false; // inicializacion de comprobante a true. También lo podemos llamar flag
            Random rnd = new Random();
            for (int i = 0; i < combinacion.Length; i++)
            {
                if (i != 0)
                {
                    do
                    {//Metemos comprobacion para saber si el numero i es igual a numero i+1 o i-1. Metodo pseudoburbuja


                    }
                    while (!comprobante); // si comprobante es false entonces se continua con la asignacion de RND }

                }
            }
        }
    }
}
