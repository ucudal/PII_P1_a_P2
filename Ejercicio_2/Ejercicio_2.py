def vote(candidate):
    if candidate == 'A':
        return "Usted a votado por el partido Rojo"
    elif candidate == 'B':
        return "Usted a votado por el partido Verde"
    elif candidate == 'C':
        return "Usted a votado por el partido Azul"
    else:
        return "Opción errónea"

print("Python")
print("A - Partido Rojo")
print("B - Partido Verde")
print("C - Partido Azul")
print()

option = input("Ingrese opción: ")
option = option.upper()

print(vote(option))
