namespace Ejercicio5b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool valido = false;
            do
            {
                try
                {
                    Console.WriteLine("Introduce un numero");
                    numero = Int32.Parse(Console.ReadLine());
                    MultiploCincoStatic.EsMultiploCinco(numero);
                    valido = true;
                }
                catch (Exception e) { Console.WriteLine(e.Message); }

            }
            while (valido != true);
        }
    }
}
