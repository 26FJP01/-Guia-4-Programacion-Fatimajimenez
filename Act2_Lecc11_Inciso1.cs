internal class Program
{
    private static void Main(string[] args)
    {
            Console.WriteLine("=========================================");
            Console.WriteLine("   LECCION 11 - ACTIVIDAD 2 - INCISO 1");
            Console.WriteLine("      BUCLE DO-WHILE (REPETIR)");
            Console.WriteLine("==========================================");
            int limite, actual = 2, iteracion = 1;
            Console.Write("Ingrese un limite entre 2 y 1000: ");
            if (int.TryParse(Console.ReadLine(), out limite))
            {
                if (limite >= 2 && limite <= 1000)
                {
                    Console.WriteLine("\nGenerando lista de pares:");
                    Console.WriteLine("-----------------------");
                    do
                    {
                        Console.WriteLine($"[Par #{iteracion}]: {actual}");
                        actual += 2;   
                        iteracion++;  
                    }
                    while (actual <= limite);
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Proceso finalizado con éxito.");
                }
                else
                {
                    Console.WriteLine("Error: El numero debe estar entre 2 y 1000.");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida.");
            }
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
