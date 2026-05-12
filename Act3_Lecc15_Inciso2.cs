internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 15 - ACTIVIDAD 3 - INCISO 2");
        Console.WriteLine("    REGRESIVA 300 A 1 - PRIMOS Y PARES");
        Console.WriteLine("========================================");
        int numero = 300;
        int cantidadPrimos = 0;
        int sumaPares = 0;
        while (numero >= 1)
        {
            Console.WriteLine("Progreso del ciclo: revisando " + numero);
            if (numero % 2 == 0)
            {
                sumaPares = sumaPares + numero;
            }
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
            if (numero > 1 && divisores == 2)
            {
                cantidadPrimos = cantidadPrimos + 1;
            }
            numero = numero - 1;
        }
        Console.WriteLine("Cantidad de numeros primos entre 300 y 1: " + cantidadPrimos);
        Console.WriteLine("Suma de numeros pares entre 300 y 1: " + sumaPares);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}