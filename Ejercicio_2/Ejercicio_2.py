def votar(candidato):
    if candidato == 'A':
        return "Usted a votado por el partido Rojo"
    elif candidato == 'B':
        return "Usted a votado por el partido Verde"
    elif candidato == 'C':
        return "Usted a votado por el partido Azul"
    else:
        return "Opción errónea"

print("Python")
print("A - Partido Rojo")
print("B - Partido Verde")
print("C - Partido Azul")
print()

opc = input("Ingrese opción: ")
opc = opc.upper()

print(votar(opc))
