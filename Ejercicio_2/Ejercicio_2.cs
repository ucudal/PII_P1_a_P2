Console.WriteLine("C#");
Console.WriteLine("A - Partido Rojo");
Console.WriteLine("B - Partido Verde");
Console.WriteLine("C - Partido Azul");
Console.WriteLine();

Console.Write("Ingrese opción: ");
string option = Console.ReadLine();
option = option.ToUpper();

Console.WriteLine(Functions.Vote(option));

public static class Functions
{
    public static string Vote(string candidate)
    {
        if (candidate == "A")
        {
            return "Usted a votado por el partido Rojo";
        }
        else if (candidate == "B")
        {
            return "Usted a votado por el partido Verde";
        }
        else if (candidate == "C")
        {
            return "Usted a votado por el partido Azul";
        }
        else
        {
            return "Opción errónea";
        }
    }
    
    // public static string Vote(string candidate)
    // {
    //     switch (candidate)
    //     {
    //         case "A":
    //         {
    //             return "Usted a votado por el partido Rojo";
    //         }
    //         case "B":
    //         {
    //             return "Usted a votado por el partido Verde";
    //         }
    //         case "C":
    //         {
    //             return "Usted a votado por el partido Azul";
    //         }
    //         default:
    //         {
    //             return "Opción errónea";
    //         }
    //     }
    // }
}
