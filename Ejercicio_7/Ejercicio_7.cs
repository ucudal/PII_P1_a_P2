Console.WriteLine("C#");
Console.Write("[");
foreach (var row in Functions.GenerateLotteryBoard())
{
    Console.Write("[");
    Console.Write(String.Join(",", row));
    Console.Write("]");
}
Console.Write("]");

public static class Functions
{
    public static void GenerateNewUniqueNumber(List<int> numbersList)
    {
        int number;
        bool numberInList;
        do
        {
            number = (new Random()).Next(1, 100);
            numberInList = numbersList.Contains(number);
        } while (numberInList);

        numbersList.Add(number);
    }

    public static List<List<int>> GenerateLotteryBoard()
    {
        List<int> lotteryNumbers = new List<int>();

        for (int i = 0; i < 15; i++)
        {
            GenerateNewUniqueNumber(lotteryNumbers);
        }

        List<int> row1 = lotteryNumbers.GetRange(0, 5);
        List<int> row2 = lotteryNumbers.GetRange(5, 5);
        List<int> row3 = lotteryNumbers.GetRange(10, 5);

        List<List<int>> lotteryBoard = new List<List<int>>() { row1, row2, row3 };
        return lotteryBoard;
    }
}