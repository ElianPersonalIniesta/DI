namespace PasosDeMensajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Persona persona1 = new Persona("Pepe", 18);
            Persona persona2 = new Persona("Lucas", 23);
            Persona persona3 = new Persona("Paco", 32);
            Persona persona4 = new Persona("Julia", 28);
            Persona persona5 = new Persona("Antonio", 54);*/

            Coche coche1 = new Coche("OPEL", "Astra", "Gris", "Pepe",18);
            Console.WriteLine(coche1.ToString());
            coche1.CambioPropietario("Maria",23);
            //Console.WriteLine(persona1.ToString());
            //persona1.cambioEdad(53);
            Console.WriteLine(coche1.ToString());
            //Console.WriteLine(persona1.ToString());
        }
    }
}
