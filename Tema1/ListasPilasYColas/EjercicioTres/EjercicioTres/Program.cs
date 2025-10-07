namespace EjercicioTres
{
    public class Program
    {
        static void Main(string[] args)
        {
            ///Declaramos la cola Queue de personas para poder manejarla
            Queue<Persona> colaPersonas = new Queue<Persona>();
            int precio = 0;
            for(int i = 0; i < Persona.generaNumAleatorio(0,51); i++)
            {
                colaPersonas.Enqueue(new Persona());
            }
            ///Guardo el nº total de gente de la cola para poder iterar sobre ella
            int totalCola = colaPersonas.Count;
            ///Quiero que me muestre que todos están encolados
            for(int i = 0; i <totalCola; i++)
            {
                Console.Write(i + ": " + (colaPersonas.ToList())[i].getEdad()+" ");
            }
            Console.WriteLine();

            ///Desencolamos
            for(int i = 0; i<totalCola; i++)
            {
                int temp = colaPersonas.Dequeue().getEdad(); /// DESENCOLAMOS Y SACAMOS EDAD SOY UN GENIO
                if (temp<10)
                {
                    precio += 3;
                    Console.WriteLine("Cliente desencolado, +3. Quedan" + colaPersonas.Count + " clientes");
                }
                else if (temp > 10 && temp < 17)
                {
                    precio += 5;
                    Console.WriteLine("Cliente desencolado, +5. Quedan" + colaPersonas.Count + " clientes");
                }
                else
                {
                    precio += 7;
                    Console.WriteLine("Cliente desencolado, +7. Quedan: "+colaPersonas.Count+" clientes");
                }
            }
            Console.WriteLine("Total recaudado: "+precio);

        }
    }
}
