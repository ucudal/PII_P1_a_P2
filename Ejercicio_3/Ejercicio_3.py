def message_for_day(week_day):
    if week_day.lower() == "lunes":
        return "Hoy comienza la semana. ¡Ánimo!"
    elif week_day.lower() == "viernes":
        return "Ya casi termina!"
    elif week_day.lower() == "sábado" or \
            week_day.lower() == "domingo":
        return "¡Siiii! ¡Fin de semana!"
    elif (week_day.lower() == "martes" or
          week_day.lower() == "miércoles" or
          week_day.lower() == "jueves"):
        return "¡Vamos que se puede!"
    else:
        return "¡Dia de la semana invalido!"


print("Python")
input_day = input("Ingrese el día de la semana: ")
print(message_for_day(input_day))
