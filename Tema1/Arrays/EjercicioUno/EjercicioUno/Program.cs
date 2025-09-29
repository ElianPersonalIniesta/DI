namespace EjercicioUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int [] numeros = new int[20];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Aleatorio.numAleatorio();
                for(int j = 0;j < numeros[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < numeros.Length; i++) 
            {
                Console.WriteLine (numeros[i]);
            }

        }
    }
}
