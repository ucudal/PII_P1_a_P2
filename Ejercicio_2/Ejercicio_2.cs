static class Program
{
    static string Votar(string candidato)
    {
        if (candidato == "A")
        {
            return "Usted a votado por el partido Rojo";
        }
        else if (candidato == "B")
        {
            return "Usted a votado por el partido Verde";
        }
        else if (candidato == "C")
        {
            return "Usted a votado por el partido Azul";
        }
        else
        {
            return "Opción errónea";
        }
    }
    
    static string VotarSwitch(string candidato)
    {
        switch (candidato)
        {
            case "A":
            {
                return "Usted a votado por el partido Rojo";
            }
            case "B":
            {
                return "Usted a votado por el partido Verde";
            }
            case "C":
            {
                return "Usted a votado por el partido Azul";
            }
            default:
            {
                return "Opción errónea";
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("C#");
        Console.WriteLine("A - Partido Rojo");
        Console.WriteLine("B - Partido Verde");
        Console.WriteLine("C - Partido Azul");
        Console.WriteLine();

        Console.Write("Ingrese opción: ");
        string opc = Console.ReadLine();
        opc = opc.ToUpper();

        Console.WriteLine(Votar(opc));
        Console.WriteLine(VotarSwitch(opc));
    }
}
