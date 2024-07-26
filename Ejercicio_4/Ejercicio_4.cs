static class Program
{
    // static void Main()
    // {
    //     Console.WriteLine("C#");
    //     
    //     int suma = 0;
    //     int numero;
    //     do
    //     {
    //         Console.Write("Ingrese número (0 para terminar): ");
    //         numero = int.Parse(Console.ReadLine());
    //         if (numero > 0)
    //         {
    //             suma = suma + numero;
    //         }
    //     } while (numero != 0);
    //     
    //
    //     Console.WriteLine("La suma es: " + suma.ToString());
    // }
    
    static void Main()
    {
        Console.WriteLine("C#");
        
        int suma = 0;
        Console.Write("Ingrese número (0 para terminar): ");
        int numero = int.Parse(Console.ReadLine());
        while (numero != 0)
        {
            if (numero > 0)
            {
                suma = suma + numero;
            }
    
            Console.Write("Ingrese número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());
        }
    
        Console.WriteLine("La suma es: " + suma.ToString());
    }
}
