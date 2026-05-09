internal class Program
{
    private static void Main(string[] args)
    {
            Console.WriteLine("========================================");
            Console.WriteLine("   LECCION 10 - ACTIVIDAD 2 - INCISO 2");
            Console.WriteLine("       ENTEROS PARES - CICLO FOR");
            Console.WriteLine("========================================");
            int limite;
            Console.Write("Ingrese el numero limite: ");
            if (int.TryParse(Console.ReadLine(), out limite))
            {
                if (limite >= 2)
                {
                    Console.WriteLine("\nIniciando analisis de pares...");
                  for (int i = 2; i <= limite; i += 2)
                    {
                        Console.WriteLine($"Revisando: {i} -> ¡Es par!");
                    }
                }
                else
                {
                    Console.WriteLine("El numero debe ser mayor o igual a 2.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un numero valido.");
            }
            Console.WriteLine("\n========================================");
            Console.WriteLine("Proceso terminado.");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
