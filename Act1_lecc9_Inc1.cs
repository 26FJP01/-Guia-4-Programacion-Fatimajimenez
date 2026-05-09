internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("   LECCION 09 - ACTIVIDAD 1 - INCISO 1");
        Console.WriteLine("        COMPRANDO MANZANAS - WHILE");
        Console.WriteLine("========================================");
        Console.WriteLine("El objetivo es juntar 1 kilo de manzanas.");
        Console.WriteLine("Ingrese el peso de cada manzana en gramos.");
        Console.WriteLine();
        int pesoTotal = 0;
        int contador = 1;
        int pesoManzana;
        while (pesoTotal < 1000)
        {
            Console.Write("Peso de la manzana " + contador + " en gramos: ");
            pesoManzana = int.Parse(Console.ReadLine());
            if (pesoManzana > 0)
            {
                pesoTotal = pesoTotal + pesoManzana;
                Console.WriteLine("Progreso del ciclo: manzana " + contador + " registrada.");
                Console.WriteLine("Peso acumulado: " + pesoTotal + " gramos de 1000 gramos.");
                contador = contador + 1;
            }
            else
            {
                Console.WriteLine("El peso debe ser mayor que cero. Intente otra vez.");
            }

            Console.WriteLine("----------------------------------------");
        }
        Console.WriteLine("Ya tiene por lo menos 1 kilo de manzanas.");
        Console.WriteLine("Peso final: " + pesoTotal + " gramos.");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}