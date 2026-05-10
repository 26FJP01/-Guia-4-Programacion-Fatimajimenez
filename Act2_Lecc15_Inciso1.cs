internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 15 - ACTIVIDAD 2 - INCISO 1");
        Console.WriteLine("    PRIMOS ENTRE 1 Y 100 Y SU SUMA");
        Console.WriteLine("========================================");
        int numero = 1;
        int cantidadPrimos = 0;
        int sumaPrimos = 0;
        while (numero <= 100)
        {
            int divisor = 1;
            int divisores = 0;

            while (divisor <= numero)
            {
                if (numero % divisor == 0)
                {
                    divisores = divisores + 1;
                }

                divisor = divisor + 1;
            }
            Console.WriteLine("Progreso del ciclo: revisando numero " + numero + " de 100");
            if (numero > 1 && divisores == 2)
            {
                cantidadPrimos = cantidadPrimos + 1;
                sumaPrimos = sumaPrimos + numero;
                Console.WriteLine(numero + " es primo.");
            }
            numero = numero + 1;
        }

        Console.WriteLine("Cantidad de numeros primos: " + cantidadPrimos);
        Console.WriteLine("Suma de numeros primos: " + sumaPrimos);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}