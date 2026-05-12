internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 23 - ACTIVIDAD 4 - INCISO 1");
        Console.WriteLine("     TABLA DE MULTIPLICAR EN C# - WHILE");
        Console.WriteLine("========================================");

        Console.Write("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());
        int contador = 1;
        int resultado;

        while (contador <= 10)
        {
            resultado = numero * contador;
            Console.WriteLine("Progreso del ciclo: linea " + contador + " de 10");
            Console.WriteLine(numero + " x " + contador + " = " + resultado);
            contador = contador + 1;
        }

        Console.WriteLine("Tabla terminada.");
        Console.WriteLine("Presione una tecla para salir...");

    }
}