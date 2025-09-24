namespace EjercicioTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int dado;
            Random rand = new Random();
            for (int i = 0; i <= 50; i++) {
                dado=rand.Next(1,7);
                if (dado == 1)
                {
                    contador++;
                }
            }
            Console.WriteLine("El 1 ha aparecido: "+contador);
        }
    }
}
