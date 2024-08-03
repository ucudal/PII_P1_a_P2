import random


def roll_dice():
    return random.randint(1, 6)


def average_20():
    i = 0
    total = 0
    while i < 20:
        dice1 = roll_dice()
        dice2 = roll_dice()
        total += dice1 + dice2
        i = i + 1
    print("Promedio total:", total / 20)
    print()


def simulate_30():
    i = 0
    face1, face2, face3, face4, face5, face6 = 0, 0, 0, 0, 0, 0
    while i < 30:
        dice = roll_dice()
        if dice == 1:
            face1 += 1
        elif dice == 2:
            face2 += 1
        elif dice == 3:
            face3 += 1
        elif dice == 4:
            face4 += 1
        elif dice == 5:
            face5 += 1
        elif dice == 6:
            face6 += 1
        i += 1
    print("cara 1:", face1)
    print("cara 2:", face2)
    print("cara 3:", face3)
    print("cara 4:", face4)
    print("cara 5:", face5)
    print("cara 6:", face6)
    print()


print("Python")
average_20()
simulate_30()
