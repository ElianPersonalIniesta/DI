namespace Ejercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaramos objeto de tipo Random para poder tener "aleatoridad"
            Random random = new Random();
            //Declaracion del Array del 0 al 10
            int[] frecuencia = new int[11];
            //aqui uso el valor del random en un rango del 1 al 10 y segun el numero se incrementa el valor de la celda
            for(int i = 0; i < 10000; i++)
            {
                int indice = random.Next(1, 11);
                frecuencia[indice]++;
            }
            //Impresion
            Console.WriteLine("FRECUENCIAS");
            for(int i = 1;i < frecuencia.Length; i++)
            {
                Console.WriteLine("Numero "+i+" : "+frecuencia[i]);
            }
        }
    }
}
