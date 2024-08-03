import random


def generate_new_unique_number(numbers_list):
    number = random.randint(1, 99)
    number_in_list = number in numbers_list
    while number_in_list:
        number = random.randint(1, 99)
        number_in_list = number in numbers_list
    numbers_list.append(number)


# def generate_new_unique_number(numbers_list):
#     number = 0
#     number_in_list = True
#     while number_in_list:
#         number = random.randint(1, 99)
#         number_in_list = number in numbers_list
#     numbers_list.append(number)


def generate_lottery_board():
    lottery_numbers = []

    for i in range(15):
        generate_new_unique_number(lottery_numbers)

    row1 = lottery_numbers[0:5]
    row2 = lottery_numbers[5:10]
    row3 = lottery_numbers[10:15]

    lottery_board = [row1, row2, row3]
    return lottery_board


print("Python")
print(generate_lottery_board())
