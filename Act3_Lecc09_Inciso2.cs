internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 09 - ACTIVIDAD 3 - INCISO 2");
        Console.WriteLine("       NUMERO PRIMO - WHILE");
        Console.WriteLine("========================================");

        Console.Write("Ingrese un numero entero: ");
        int numero = int.Parse(Console.ReadLine());
        int divisor = 1;
        int divisores = 0;

        while (divisor <= numero)
        {
            Console.WriteLine("Progreso del ciclo: probando divisor " + divisor);

            if (numero % divisor == 0)
            {
                divisores = divisores + 1;
            }

            divisor = divisor + 1;
        }

        if (numero > 1 && divisores == 2)
        {
            Console.WriteLine(numero + " es un numero primo.");
        }
        else
        {
            Console.WriteLine(numero + " no es un numero primo.");
        }

        Console.WriteLine("Cantidad de divisores encontrados: " + divisores);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}