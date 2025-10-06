namespace PruebaLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Esto es una lista de strings!
            List <string> listaColores = new List<string>();
            ///Se agrega elementos asin
            listaColores.Add("owowowo");
            listaColores.Add("claro k si");
            listaColores.Add("sabe k tengo");
            listaColores.Add("un pikete espacial");
            Console.WriteLine(listaColores[0]);
            ///Contttttttt
            Console.WriteLine(listaColores.IndexOf("amarillo chillon"));


            ///Mostrar todo lo de la lsita
            foreach(string miau in listaColores)
            {
                Console.WriteLine(miau);
            }
            Console.WriteLine("Hello, World!");
        }
    }
}
