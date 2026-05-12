internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 15 - ACTIVIDAD 3 - INCISO 1");
        Console.WriteLine(" MULTIPLOS DE 7, SUMA Y PARES - WHILE");
        Console.WriteLine("========================================");
        int contador = 1;
        int multiplo;
        int suma = 0;
        int pares = 0;
        while (contador <= 20)
        {
            multiplo = 7 * contador;
            suma = suma + multiplo;
            Console.WriteLine("Progreso del ciclo: multiplo " + contador + " de 20");
            Console.WriteLine("Multiplo: " + multiplo + " | Suma actual: " + suma);

            if (multiplo % 2 == 0)
            {
                pares = pares + 1;
            }
            contador = contador + 1;
        }
        Console.WriteLine("Suma total de los 20 multiplos de 7: " + suma);
        Console.WriteLine("Cantidad de multiplos pares: " + pares);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}