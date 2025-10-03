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
            bool comprobante;// inicializacion de comprobante a true. También lo podemos llamar flag
            Random rnd = new Random();
            for (int i = 0; i < combinacion.Length; i++)
            {
                int temp;
                do
                {
                    comprobante = true;
                    temp = rnd.Next(1,50);
                    for(int j = 0; j < combinacion.Length; j++)
                    {
                        if (temp == combinacion[j]) { comprobante = false; }
                    }
                }
                while (!comprobante);
                combinacion[i] = temp;
            }
        }

        ///Metodo para devolver un array de enteros.
        ///Auxiliar para el Equals. No se si es lo correcto.
        public int[] getCombinacion()
        {
            int[] numero = new int[combinacion.Length];
            for(int i = 0;i < combinacion.Length; i++)
            {
                numero[i] = combinacion[i];
            }
            return numero;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object? bol)
        {
            Boleto miBoleto2 = (Boleto) bol;
            bool flag = false;
            int[] aux = miBoleto2.getCombinacion();
            int[] auxPrincipal = this.getCombinacion();
            for(int i = 0; i < aux.Length; i++)
            {
                /// KEDA HACER OTRO FOR, EL FLAG TAMBIEN TIENE QUE COMPROBAR SI TIENE UN FLAG
                /// MIRA A VER COMO OVERRIDEAR EL TOSTRING Y COMO IMPLEMENTARLO PARA MIL BOLETOS!!!!!
            }
            return base.Equals(bol);
        }
        
    }
}
