Console.WriteLine("C#");
Functions.Average20();
Functions.Simulate30();

public static class Functions
{
    public static int DrawDice()
    {
        return new Random().Next(1, 6);
    }

    public static void Average20()
    {
        int i = 0;
        int total = 0;
        while (i < 20)
        {
            int dice1 = DrawDice();
            int dice2 = DrawDice();
            total += dice1 + dice2;
            i = i + 1;
        }

        Console.WriteLine("Promedio suma:" + (total / 20).ToString());
    }

    public static void Simulate30()
    {
        int i = 0;
        int face1 = 0, face2 = 0, face3 = 0, face4 = 0, face5 = 0, face6 = 0;
        while (i < 30)
        {
            int dado = DrawDice();
            switch (dado)
            {
                case 1:
                    face1 += 1;
                    break;
                case 2:
                    face2 += 1;
                    break;
                case 3:
                    face3 += 1;
                    break;
                case 4:
                    face4 += 1;
                    break;
                case 5:
                    face5 += 1;
                    break;
                case 6:
                    face6 += 1;
                    break;
            }

            i += 1;
        }
        
        Console.WriteLine("cara 1:" + face1.ToString());
        Console.WriteLine("cara 2:" + face2.ToString());
        Console.WriteLine("cara 3:" + face3.ToString());
        Console.WriteLine("cara 4:" + face4.ToString());
        Console.WriteLine("cara 5:" + face5.ToString());
        Console.WriteLine("cara 6:" + face6.ToString());
    }
}
