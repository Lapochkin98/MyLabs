import math
#Функция
def square(x):
    p = x * 4
    s = x ** 2
    d = math.sqrt(x*x*2)
    result = (p,s,d)
    return result
#Основа
x = int(input('Введите сторону квадрата: '))
print(square(x))