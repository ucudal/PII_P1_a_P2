def mensaje(dia_semana):
    if dia_semana.lower() == "lunes":
        print("Hoy comienza la semana. ¡Ánimo!")
    elif dia_semana.lower() == "viernes":
        print("Ya casi termina!")
    elif dia_semana.lower() == "sábado" or \
            dia_semana.lower() == "domingo":
        print("¡Siiii! ¡Fin de semana!")
    elif (dia_semana.lower() == "martes" or
          dia_semana.lower() == "miércoles" or
          dia_semana.lower() == "jueves"):
        print("¡Vamos que se puede!")
    else:
        print("¡Dia de la semana invalido!")


dia_sem = input("Ingrese el día de la semana > ")
mensaje(dia_sem)
