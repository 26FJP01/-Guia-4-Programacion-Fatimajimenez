internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 10 - ACTIVIDAD 3 - INCISO 1");
        Console.WriteLine("    PRIMO ENTRE 1 Y 22 - FOR");
        Console.WriteLine("========================================");

        Console.Write("Ingrese un numero entre 1 y 22: ");
        int numero = int.Parse(Console.ReadLine());
        int divisores = 0;

        if (numero >= 1 && numero <= 22)
        {
            for (int divisor = 1; divisor <= numero; divisor++)
            {
                Console.WriteLine("Progreso del ciclo: probando divisor " + divisor);

                if (numero % divisor == 0)
                {
                    divisores = divisores + 1;
                }
            }

            if (numero > 1 && divisores == 2)
            {
                Console.WriteLine(numero + " es primo.");
            }
            else
            {
                Console.WriteLine(numero + " no es primo.");
            }
        }
        else
        {
            Console.WriteLine("El numero no esta entre 1 y 22.");
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}