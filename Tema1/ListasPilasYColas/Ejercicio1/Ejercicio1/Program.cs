namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista1 = new List<string>();
            List<int> lista2 = new List<int>();
            string str = "";
            do
            {
                str = Console.ReadLine();
                if (str != "fin")
                {
                    lista1.Add(str);
                    lista2.Add(str.Length);
                }
            }
            while (str != "fin");
            for(int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine(lista1[i]);
                Console.WriteLine(lista2[i]);
            }
        }
    }
}
