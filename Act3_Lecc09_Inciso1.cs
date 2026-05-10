internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 9 - ACTIVIDAD 3 - INCISO 1");
        Console.WriteLine("        ENTEROS IMPARES - WHILE");
        Console.WriteLine("========================================");

        Console.Write("Ingrese un numero entero: ");
        int numero = int.Parse(Console.ReadLine());
        int inicio;
        int fin;

        if (numero >= 20)
        {
            inicio = 20;
            fin = numero;
        }
        else
        {
            inicio = numero;
            fin = 20;
        }

        int contador = inicio;
        int paso = 1;

        Console.WriteLine("Impares comprendidos entre " + inicio + " y " + fin + ":");

        while (contador <= fin)
        {
            Console.WriteLine("Progreso del ciclo: revision " + paso + " con el numero " + contador);

            if (contador % 2 != 0)
            {
                Console.WriteLine(contador + " es impar.");
            }

            contador = contador + 1;
            paso = paso + 1;
        }

        Console.WriteLine("Proceso terminado.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }

}
