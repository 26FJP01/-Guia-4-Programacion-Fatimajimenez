internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 11 - ACTIVIDAD 2 - INCISO 3");
        Console.WriteLine("     MULTIPLOS DE 4 ENTRE DOS NUMEROS");
        Console.WriteLine("========================================");
        Console.Write("Ingrese el primer numero: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine());
        int menor;
        int mayor;
        if (numero1 <= numero2)
        {
            menor = numero1;
            mayor = numero2;
        }
        else
        {
            menor = numero2;
            mayor = numero1;
        }
        int contador = menor;
        int paso = 1;
        do
        {
            Console.WriteLine("Progreso del ciclo: revisando " + contador + " | paso " + paso);

            if (contador % 4 == 0)
            {
                Console.WriteLine(contador + " es multiplo de 4.");
            }
            contador = contador + 1;
            paso = paso + 1;
        }
        while (contador <= mayor);
        Console.WriteLine("Proceso terminado.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}