total = 0
number = int(input("Ingrese número (0 para terminar): "))
while number != 0:
    if number > 0:
        total = total + number
    number = int(input("Ingrese número (0 para terminar): "))
print("La total es: ", total)
