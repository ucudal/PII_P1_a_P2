static class Program
{
    static int ValorAbsoluto(int n)
    {
        if (n < 0)
        {
            return n * -1;
        }
        else
        {
            return n;
        }
    }

    static void Main()
    {
        Console.WriteLine("C#");
        Console.WriteLine("Valor absoluto de -52: " + ValorAbsoluto(-52).ToString());
        Console.WriteLine("Valor absoluto de 52:" + ValorAbsoluto(52).ToString());
    }
}
