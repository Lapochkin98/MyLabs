import math

def first_decorator(func):
    print("Первый декоратор запущен")
    def str_int():
        numbers = [int(x) for x in func()]
        print(str(numbers) + "\nПервый декоратор завершил работу")
        return numbers
    return str_int


def second_decorator(func):
    print('Второй декоратор запущен')
    def set_quadro():
        numbers = [x*x for x in func()]
        print(str(numbers) + "\nВторой декоратор завершил работу")
        return numbers
    return set_quadro


def third_decorator(func):
    print('Третий декоратор запущен')
    def even():
        numbers_list = func()
        if numbers_list[0] % 2 == 0:
            a = 'четное'
        else: a = 'нечетное'
        if numbers_list[1] % 2 == 0:
            b = 'четное'
        else: b = 'нечетное'
        print("Первое число - " + a, "\nВторое число - " + b + "\nТретий декоратор завершил работу")
    return even


@third_decorator
@second_decorator
@first_decorator
def func():
    a = input("Введите A: ")
    b = input("Введите B: ")
    spisok = [a,b]
    print(spisok)
    return spisok

func()
