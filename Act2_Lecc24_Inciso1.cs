internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 24 - ACTIVIDAD 2 - INCISO 1");
        Console.WriteLine("  20 MULTIPLOS DE UN NUMERO DADO - FOR");
        Console.WriteLine("========================================");
        Console.Write("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());
        int resultado;
        for (int contador = 1; contador <= 20; contador++)
        {
            resultado = numero * contador;
            Console.WriteLine("Progreso del ciclo: multiplo " + contador + " de 20");
            Console.WriteLine(numero + " x " + contador + " = " + resultado);
        }
        Console.WriteLine("Proceso terminado.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }

}
