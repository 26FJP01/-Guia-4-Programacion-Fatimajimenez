internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("   LECCION 09 - ACTIVIDAD 2 - INCISO 1");
        Console.WriteLine("       NIVEL BLOQUEADO - WHILE");
        Console.WriteLine("========================================");
        Console.WriteLine("El nivel 5 se desbloquea al llegar a 350 monedas.");
        Console.WriteLine();

        Console.Write("Ingrese cuantas monedas tiene actualmente: ");
        int monedas = int.Parse(Console.ReadLine());
        int ronda = 1;
        int ganadas;

        while (monedas < 350)
        {
            Console.WriteLine("Progreso del ciclo: intento " + ronda);
            Console.WriteLine("Monedas actuales: " + monedas + " de 350.");
            Console.Write("Cuantas monedas gano en esta ronda: ");
            ganadas = int.Parse(Console.ReadLine());

            if (ganadas > 0)
            {
                monedas = monedas + ganadas;
                ronda = ronda + 1;
            }
            else
            {
                Console.WriteLine("Debe ingresar una cantidad mayor que cero.");
            }

            Console.WriteLine("----------------------------------------");
        }

        Console.WriteLine("Felicidades, ya puede ingresar al nivel 5.");
        Console.WriteLine("Total de monedas: " + monedas);
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();

    }
}