Console.WriteLine("C#");
Console.WriteLine("Valor absoluto de -52: " + Functions.AbsoluteValue(-52).ToString());
Console.WriteLine("Valor absoluto de 52:" + Functions.AbsoluteValue(52).ToString());

public static class Functions
{
    public static int AbsoluteValue(int number)
    {
        if (number < 0)
        {
            return number * -1;
        }
        else
        {
            return number;
        }
    }
}
