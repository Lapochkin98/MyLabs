#Функция
def bank(a,years):
    for i in range(years):
        a += a * 0.1
    return a

#Основа
a = int(input('Сумма вклада: '))
years = int(input('Количество лет: '))
print(bank(a,years))