internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 11 - ACTIVIDAD 2 - INCISO 2");
        Console.WriteLine("       NUMEROS DEL 1 AL 100 - DO WHILE");
        Console.WriteLine("========================================");
        int numero = 1;
        do
        {
            Console.WriteLine("Progreso del ciclo: mostrando numero " + numero + " de 100");
            Console.WriteLine(numero);
            numero = numero + 1;
        }
        while (numero <= 100);
        Console.WriteLine("Proceso terminado.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}