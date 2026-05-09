internal class Program
{
    private static void Main(string[] args)
    {
            Console.WriteLine("========================================");
            Console.WriteLine("   LECCION 09 - ACTIVIDAD 2 - INCISO 2");
            Console.WriteLine("          SISTEMA DE MONEDAS");
            Console.WriteLine("========================================");
            int monedasActuales = 0;
            int monedasGanadas = 0;
            Console.Write("Introduce tus monedas actuales: ");
            monedasActuales = int.Parse(Console.ReadLine());
            while (monedasActuales < 350)
            {
                Console.WriteLine($"\nActualmente tienes {monedasActuales} monedas.");
                Console.WriteLine("Aun no alcanzas las 350 para el Nivel 5.");

                Console.Write("¿Cuantas monedas ganaste en esta partida?: ");
                monedasGanadas = int.Parse(Console.ReadLine());
                monedasActuales += monedasGanadas;
                Console.WriteLine("Actualizando progreso...");
            }
            Console.WriteLine("\n========================================");
            Console.WriteLine("¡Felicidades! Nivel 5 desbloqueado.");
            Console.WriteLine("Total final: " + monedasActuales + " monedas.");
            Console.WriteLine("========================================");
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

