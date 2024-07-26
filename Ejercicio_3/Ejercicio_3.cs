static class Program
{
    static void Mensaje(string diaSemana)
    {
        if (diaSemana.ToLower() == "lunes")
        {
            Console.WriteLine("Hoy comienza la semana. !Ánimo!");
        }
        else if (diaSemana.ToLower() == "viernes")
        {
            Console.WriteLine("¡Ya casi termina!");
        }
        else if (diaSemana.ToLower() == "sábado"
                 || diaSemana.ToLower() == "domingo")
        {
            Console.WriteLine("¡Siiii! ¡Fin de semana!");
        }
        else if (diaSemana.ToLower() == "martes"
                 || diaSemana.ToLower() == "miércoles"
                 || diaSemana.ToLower() == "jueves")

        {
            Console.WriteLine("¡Vamos que se puede!");
        }
        else
        {
            Console.WriteLine("¡Dia de la semana invalido!");
        }
    }

    static void Main()
    {
        Console.WriteLine("C#");
        Console.Write("Ingrese el día de la semana > ");
        string diaSem = Console.ReadLine();
        Mensaje(diaSem);
    }
}
