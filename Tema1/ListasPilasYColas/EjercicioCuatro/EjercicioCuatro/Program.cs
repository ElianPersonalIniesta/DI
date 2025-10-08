namespace EjercicioCuatro
{
    public class Program
    {
        public static int numerosAleatorios(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max + 1);
        }
        static void Main(string[] args)
        {
            ///Creamos la cola de productos
            Queue<Productos> colaProductos = new Queue<Productos>();
            double precioFinal=0;
            ///Hcemos la cola (llenamos mas bien)
            for(int i = 0; i < numerosAleatorios(1, 8); i++)
            {
                double precioTemp = Math.Round((double)numerosAleatorios(100, 5000)/100,2);
                colaProductos.Enqueue(new Productos(numerosAleatorios(1, 10), precioTemp));
            }
            Console.WriteLine("********* CANTIDAD **** PRECIO **** TOTAL");
            while (colaProductos.Count > 0)
            {
                Productos prodTemp = colaProductos.Dequeue();
                Console.WriteLine("Producto"+colaProductos.Count+"     "+prodTemp.getCantidad()+
                                    "       "+prodTemp.getPrecio()+"         "+prodTemp.precioFinal());
                precioFinal += Math.Round(prodTemp.precioFinal(),2);
            }
            Console.WriteLine("                                      " + precioFinal);
        }
    }
}
