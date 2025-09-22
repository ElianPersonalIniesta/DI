namespace EjercicioUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Inicializado a un numero !=0 para que pueda entrar dentro del bucle, mirar luego
            int numero = 32; 
            ///Contadores iniciados a 0, uno para contar el nº de numeros puestos y otro para los positivos
            int cont = 0;    
            int positivos = 0;
            ///Bucle hasta que el numero sea 0
            do
            {
                try
                {
                Console.WriteLine("Introduce un numero");

                    numero = Int32.Parse(Console.ReadLine());
                    if (numero != 0)
                    {
                        cont++;
                    }
                    if (numero>0) { positivos++; }
                    }
                catch (FormatException)
                {
                    Console.WriteLine("No has introducido un numero");
                }
            }
            while (numero != 0) ;
            Console.WriteLine("Has introducido un total de " + cont + " y son positivos " + positivos);

            Console.WriteLine("Has introducido un total de {0} y son positivos {1} ", cont, positivos);
        }
    }
}
