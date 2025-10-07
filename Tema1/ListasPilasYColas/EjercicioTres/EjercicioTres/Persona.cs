using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTres
{
    public class Persona
    {
        private int edad;
        private static Random rnd = new Random();

        public Persona()
        {
            this.edad = generaNumAleatorio(5, 61);
        }
        public int getEdad()
        {
            return edad;
        }
        public void setEdad()
        {
            ///Cambio el this.edad = edad para poner directamente la edad aleatorio de la persona
            this.edad = generaNumAleatorio(5,60);
        }
        public static int generaNumAleatorio(int minimo, int maximo)
        {
            
            return rnd.Next(minimo, (maximo + 1));
        }
    }

    }

