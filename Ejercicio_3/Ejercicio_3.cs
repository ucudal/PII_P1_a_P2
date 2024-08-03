Console.WriteLine("C#");
Console.Write("Ingrese el día de la semana: ");
string inputDay = Console.ReadLine();
Console.WriteLine(Functions.MessageForDay(inputDay));

public static class Functions
{
    public static string MessageForDay(string weekDay)
    {
        if (weekDay.ToLower() == "lunes")
        {
            return "Hoy comienza la semana. !Ánimo!";
        }
        else if (weekDay.ToLower() == "viernes")
        {
            return "¡Ya casi termina!";
        }
        else if (weekDay.ToLower() == "sábado"
                 || weekDay.ToLower() == "domingo")
        {
            return "¡Siiii! ¡Fin de semana!";
        }
        else if (weekDay.ToLower() == "martes"
                 || weekDay.ToLower() == "miércoles"
                 || weekDay.ToLower() == "jueves")

        {
            return "¡Vamos que se puede!";
        }
        else
        {
            return "¡Dia de la semana invalido!";
        }
    }
}
