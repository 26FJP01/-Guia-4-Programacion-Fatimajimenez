internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 15 - ACTIVIDAD 2 - INCISO 2");
        Console.WriteLine("      CAJERO DEL SUPERMERCADO");
        Console.WriteLine("========================================");
        Console.WriteLine("Ingrese 1000 billetes. Denominaciones validas: 20, 50 y 100.");
        Console.WriteLine();
        int contador = 1;
        int billete;
        int billetesDe100 = 0;
        int totalDinero = 0;
        while (contador <= 1000)
        {
            Console.WriteLine("Progreso del ciclo: billete " + contador + " de 1000");
            Console.Write("Ingrese denominacion del billete: ");
            billete = int.Parse(Console.ReadLine());

            if (billete == 20 || billete == 50 || billete == 100)
            {
                totalDinero = totalDinero + billete;

                if (billete == 100)
                {
                    billetesDe100 = billetesDe100 + 1;
                }
                Console.WriteLine("Total acumulado: $" + totalDinero);
                contador = contador + 1;
            }
            else
            {
                Console.WriteLine("Denominacion incorrecta. No se cuenta este billete.");
            }

            Console.WriteLine("----------------------------------------");
        }
        Console.WriteLine("Cantidad de billetes de $100: " + billetesDe100);
        Console.WriteLine("Total de dinero en el fajo: $" + totalDinero);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}