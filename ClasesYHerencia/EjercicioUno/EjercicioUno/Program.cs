namespace EjercicioUno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vehiculo coche = new Vehiculo();
            coche.mostrar();
            Vehiculo coche2 = new Vehiculo();
            coche2.setColor("Blanco");
            coche2.MaXPersonas=4;
            coche2.Ruedas=3; // le han llevado al desguace
            coche2.mostrar();
            //Pruebas de hashcode, equals y toString
            Vehiculo v1 = new Vehiculo("Amarillo", 4, 4);
            Vehiculo v2 = new Vehiculo("Rojo", 4, 4);
            Vehiculo v3 = new Vehiculo("Amarillo", 4, 4);
            Console.WriteLine(v1.Equals(v3));

        }
    }
}
