internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 15 - ACTIVIDAD 1 - INCISO 1");
        Console.WriteLine("     BOLETOS RUEDA DE LA FORTUNA");
        Console.WriteLine("========================================");
        Console.WriteLine("Adulto: $15 | Nino: $10");
        Console.WriteLine("Digite 1 para adulto, 2 para nino y 0 para terminar.");
        Console.WriteLine();
        int opcion = 1;
        int boletosAdulto = 0;
        int boletosNino = 0;
        int totalBoletos = 0;
        int totalDinero = 0;
        int paso = 1;
        while (opcion != 0)
        {
            Console.WriteLine("Progreso del ciclo: venta " + paso);
            Console.Write("Tipo de boleto: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                boletosAdulto = boletosAdulto + 1;
                totalBoletos = totalBoletos + 1;
                totalDinero = totalDinero + 15;
                Console.WriteLine("Se vendio un boleto de adulto.");
            }
            else
            {
                if (opcion == 2)
                {
                    boletosNino = boletosNino + 1;
                    totalBoletos = totalBoletos + 1;
                    totalDinero = totalDinero + 10;
                    Console.WriteLine("Se vendio un boleto de nino.");
                }
                else
                {
                    if (opcion != 0)
                    {
                        Console.WriteLine("Opcion incorrecta.");
                    }
                }
            }

            Console.WriteLine("Boletos vendidos: " + totalBoletos);
            Console.WriteLine("Dinero cobrado: $" + totalDinero);
            Console.WriteLine("----------------------------------------");
            paso = paso + 1;
        }

        Console.WriteLine("Resumen final:");
        Console.WriteLine("Adultos: " + boletosAdulto);
        Console.WriteLine("Ninos: " + boletosNino);
        Console.WriteLine("Total de boletos: " + totalBoletos);
        Console.WriteLine("Total cobrado: $" + totalDinero);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}