suma = 0
numero = int(input("Ingrese número (0 para terminar): "))
while numero != 0:
    if numero > 0:
        suma = suma + numero
    numero = int(input("Ingrese número (0 para terminar): "))
print("La suma es: ", suma)
