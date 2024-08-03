Console.WriteLine("C#");
Console.WriteLine(Functions.IsPangram(
    "El viejo Señor Gómez pedía queso, kiwi y habas, pero le ha tocado un saxofón")); // True
Console.WriteLine(Functions.IsPangram(
    "José compró una vieja zampoña en Perú. Excusándose, Sofía tiró su whisky al desagüe de la banqueta")); // True
Console.WriteLine(Functions.IsPangram(
    "El cadáver de Wamba, rey godo de España, fue exhumado y trasladado en una caja de zinc que pesó un kilo")); // True
Console.WriteLine(Functions.IsPangram(
        "Compañera usted sabe que puede contar conmigo no hasta dos ni hasta diez sino contar conmigo.")); // False

public static class Functions
{
    public static string NormalizeString(string stringToNormalize)
    {
        string accentedChars = "áéíóúü";
        string normalizedChars = "aeiouu";
        string normalizedString = "";
        foreach (char letter in stringToNormalize.ToLower())
        {
            int indexOfAccentedChar = accentedChars.IndexOf(letter);
            if (indexOfAccentedChar >= 0)
            {
                normalizedString += normalizedChars[indexOfAccentedChar];
            }
            else
            {
                normalizedString += letter;
            }
        }

        return normalizedString;
    }

    public static bool IsPangram(string inputString)
    {
        string alphabet = "abcdefghijklmnñopqrstuvwxyz";
        string normalizedInput = NormalizeString(inputString);
        foreach (char letter in alphabet)
        {
            if (normalizedInput.IndexOf(letter) < 0)
            {
                return false;
            }
        }
        
        return true;
    }
}