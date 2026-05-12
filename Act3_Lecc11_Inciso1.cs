internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 11 - ACTIVIDAD 3 - INCISO 1");
        Console.WriteLine("       SUMA ENTRE DOS NUMEROS");
        Console.WriteLine("========================================");
        Console.Write("Ingrese el primer numero: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine());
        int menor;
        int mayor;
        int suma = 0;
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
        do
        {
            suma = suma + contador;
            Console.WriteLine("Progreso del ciclo: se sumo " + contador + " | suma actual: " + suma);
            contador = contador + 1;
        }
        while (contador <= mayor);
        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}