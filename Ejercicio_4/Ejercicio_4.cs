Console.WriteLine("C#");
Functions.Sum();

public static class Functions
{
    public static void Sum()
    {
        int total = 0;
        Console.Write("Ingrese número (0 para terminar): ");
        int number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            if (number > 0)
            {
                total = total + number;
            }
    
            Console.Write("Ingrese número (0 para terminar): ");
            number = int.Parse(Console.ReadLine());
        }
    
        Console.WriteLine("La suma es: " + total.ToString());
    }
    
    // public static void Sum()
    // {
    //     int total = 0;
    //     int number;
    //     do
    //     {
    //         Console.Write("Ingrese número (0 para terminar): ");
    //         number = int.Parse(Console.ReadLine());
    //         if (number > 0)
    //         {
    //             total = total + number;
    //         }
    //     } while (number != 0);
    //     
    //
    //     Console.WriteLine("La suma es: " + total.ToString());
    // }
}
