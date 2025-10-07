namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Creamos la lista de personas.
            List<Persona> lista1 = new List<Persona>();
            string str = "";
            ///Bucle para meter personas si no ponemos fin
            do
            {
                str = Console.ReadLine();
                if (str != "fin")
                {
                    lista1.Add(new Persona(str));
                }
            }
            while (str != "fin");
            ///Bucle for para recorrer la lista de personas.
            for(int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine("Nombre: "+lista1[i].Nombre+" longitud: " + lista1[i].Longitud);
            }
        }
    }
}
