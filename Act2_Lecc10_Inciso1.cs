internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 10 - ACTIVIDAD 2 - INCISO 1");
        Console.WriteLine("    PRIMEROS 20 MULTIPLOS DE 4 - FOR");
        Console.WriteLine("========================================");
        int resultado;
        for (int contador = 1; contador <= 20; contador++)
        {
            resultado = 4 * contador;
            Console.WriteLine("Progreso del ciclo: multiplo " + contador + " de 20");
            Console.WriteLine("4 x " + contador + " = " + resultado);
        }
        Console.WriteLine("Proceso terminado.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}