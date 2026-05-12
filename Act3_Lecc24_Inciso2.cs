internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 24 - ACTIVIDAD 3 - INCISO 1");
        Console.WriteLine("     SUMA DE PRIMOS ENTRE 1 Y 50 - FOR");
        Console.WriteLine("========================================");

        int sumaPrimos = 0;

        for (int numero = 1; numero <= 50; numero++)
        {
            int divisores = 0;

            for (int divisor = 1; divisor <= numero; divisor++)
            {
                if (numero % divisor == 0)
                {
                    divisores = divisores + 1;
                }
            }

            Console.WriteLine("Progreso del ciclo: revisando " + numero + " de 50");

            if (numero > 1 && divisores == 2)
            {
                sumaPrimos = sumaPrimos + numero;
                Console.WriteLine(numero + " es primo. Suma actual: " + sumaPrimos);
            }
        }

        Console.WriteLine("La suma de los numeros primos entre 1 y 50 es: " + sumaPrimos);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}