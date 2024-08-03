def normalize_string(string_to_normalize):
    accented_characters = "áéíóúü"
    normalized_characters = "aeiouu"
    normalized_string = ""
    for letter in string_to_normalize.lower():
        index_of_accented_character = accented_characters.find(letter)
        if index_of_accented_character >= 0:
            normalized_string += normalized_characters[index_of_accented_character]
        else:
            normalized_string += letter
    return normalized_string


def is_pangram(input_string):
    alphabet = "abcdefghijklmnñopqrstuvwxyz"
    normalized_string = normalize_string(input_string)
    for letter in alphabet:
        if letter not in normalized_string:
            return False
    return True


print("Python")
print(is_pangram("El viejo Señor Gómez pedía queso, kiwi y habas, pero le ha tocado un saxofón")) # True
print(is_pangram("José compró una vieja zampoña en Perú. Excusándose, Sofía tiró su whisky al desagüe de la banqueta")) # True
print(is_pangram("El cadáver de Wamba, rey godo de España, fue exhumado y trasladado en una caja de zinc que pesó un kilo")) # True
print(is_pangram("Compañera usted sabe que puede contar conmigo no hasta dos ni hasta diez sino contar conmigo.")) # False