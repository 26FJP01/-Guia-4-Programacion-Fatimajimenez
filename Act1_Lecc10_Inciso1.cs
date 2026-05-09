internal class Program
{
    private static void Main(string[] args)
    {
        const int TOTAL_SELLOS = 8;
        Console.WriteLine("-----Bienvenido a la Barberia---------");
        for (int i = 1; i <= TOTAL_SELLOS; i++)
        {
            Console.WriteLine("\nSello actual{0} de {1}", i, TOTAL_SELLOS);
            Console.WriteLine("Presione cualquier tecla para registrar esta");
            Console.ReadKey();
            Console.WriteLine(">>sellos#{0} registrar correctamente ....");
        }
        Console.WriteLine(">>sellos#{0} registrar correctamente ....");
        Console.WriteLine("¡CUPONERA CPMPLETA!");
        Console.WriteLine("has ganado tu corte de cabello gratis");
        Console.WriteLine("\n*****************************");
        Console.WriteLine("\nPresione una tecla para cerrar");
        Console.ReadKey();
    }
}