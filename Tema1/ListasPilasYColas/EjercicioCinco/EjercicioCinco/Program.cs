namespace EjercicioCinco
{
    public class Program
    {
        public static  int aleatorio()
        {
            Random rnd = new Random();
            return rnd.Next(0, 3);
        }
        static void Main(string[] args)
        {
            ///Declaración de Pila tipo Informe
            Stack<Informe> pilaInformes = new Stack<Informe>();
            int codigID;
            for(int i = 0; i < 10; i++)
            {
                codigID = i;
                pilaInformes.Push(new Informe(codigID, aleatorio()));
            }
            ///Sacamos 5 informes
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("--> " + pilaInformes.Pop().ToString());
            }
            ///Agregamos otros 5 informes
            for (int i = 0; i < 5; i++)
            {
                codigID = i;
                pilaInformes.Push(new Informe(codigID, aleatorio()));
            }
            ///Sacamos todos los informes
            while (pilaInformes.Count > 0)
            {
                Console.WriteLine("--> " + pilaInformes.Pop().ToString());
            }
        }
    }
}
