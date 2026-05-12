internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 24 - ACTIVIDAD 3 - INCISO 2");
        Console.WriteLine("      CUENTA REGRESIVA Y SUMA - FOR");
        Console.WriteLine("========================================");

        Console.Write("Ingrese un numero entero positivo: ");
        int numero = int.Parse(Console.ReadLine());
        int suma = 0;

        if (numero >= 1)
        {
            for (int contador = numero; contador >= 1; contador--)
            {
                suma = suma + contador;
                Console.WriteLine("Progreso del ciclo: numero " + contador + " | suma actual: " + suma);
            }

            Console.WriteLine("La suma total es: " + suma);
        }
        else
        {
            Console.WriteLine("Debe ingresar un numero mayor o igual a 1.");
        }

        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}