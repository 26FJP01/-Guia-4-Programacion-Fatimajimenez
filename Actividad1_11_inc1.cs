internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 11 - ACTIVIDAD 1 - INCISO 1");
        Console.WriteLine("       ESTACIONAMIENTO - DO WHILE");
        Console.WriteLine("========================================");
        Console.WriteLine("El estacionamiento tiene cupo para 20 autos.");
        Console.WriteLine("Presione una tecla cada vez que ingrese un auto.");
        Console.WriteLine();
        int autos = 0;
        int espacios = 20;
        do
        {
            Console.WriteLine("Progreso del ciclo: auto " + (autos + 1) + " de 20");
            Console.WriteLine("Presione una tecla para registrar el ingreso del auto...");
            Console.ReadKey();
            Console.WriteLine();
            autos = autos + 1;
            espacios = 20 - autos;
            Console.WriteLine("Autos dentro: " + autos);
            Console.WriteLine("Espacios vacios: " + espacios);
            Console.WriteLine("----------------------------------------");
        }
        while (autos < 20);
        Console.WriteLine("El estacionamiento esta lleno.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}