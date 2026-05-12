internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 11 - ACTIVIDAD 3 - INCISO 2");
        Console.WriteLine("       SUMAR HASTA INGRESAR 0");
        Console.WriteLine("========================================");
        Console.WriteLine("Ingrese numeros para sumarlos. Para terminar ingrese 0.");
        Console.WriteLine();
        int numero;
        int suma = 0;
        int contador = 1;
        do
        {
            Console.WriteLine("Progreso del ciclo: lectura " + contador);
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            suma = suma + numero;
            Console.WriteLine("Suma actual: " + suma);
            contador = contador + 1;
            Console.WriteLine("----------------------------------------");
        }
        while (numero != 0);
        Console.WriteLine("El usuario ingreso 0, por eso termino el ciclo.");
        Console.WriteLine("La suma final es: " + suma);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}