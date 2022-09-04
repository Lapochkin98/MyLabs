import pandas as pd
import numpy as np

print("Задание 1:")
array = []
for i in range(5):
    array += list(map(int, input().split()))
s_array = pd.Series(array)
print("Итог: ")
print(s_array)


array_2 = []
array_2_index = []
print("Введите 5 чисел в массив: ")
for i in range(5):
    array_2 += list(map(int, input().split()))
print("Введите индексы:")
for i in range(5):
    array_2_index += list(map(str,input().split()))
s_array = pd.Series(array_2, index = array_2_index)
print("Итог: ")
print(s_array)

print("\nЗадание 3")
s_array = pd.Series(array_2)
N = int(input("Введите до чего сделать срез: "))
print("Итог: ")
print(s_array[:N])


print("Задание 4")
array_4 = []
array_4_index = []
print("Введите 5 чисел в массив: ")
for i in range(5):
    array_2 += list(map(int, input().split()))
print("Введите индексы:")
for i in range(5):
    array_2_index += list(map(str,input().split()))
s_array = pd.Series(array_2, index = array_2_index)

first_metka = int(input("Введите первую метку: "))
print("Итог: ")
print(s_array[first_metka])


print("Задание 5")
print("Итог: ")
print(s_array[s_array < 2])


print("Задание 6")
s_array = pd.Series([2,3,4,5,6,7,8])
print("Оперция деления на 2: ")
print(s_array / 2)
print("Операция увеличения на 2: ")
print(s_array + 2)


print("Задание 7")
s_array_new = pd.Series([1,2,3,4,5,5,6,6,7,7], index = [1,2,3,4,5,5,6,6,7,7])
print("Итог: ")
print(s_array_new)


print("Задание 8")
print("Уникальные значения: ")
print(s_array_new.value_counts())


print("Задание 9")
first_number = int(input("Введите ваше число: "))
second_number = int(input("Введите ваше число: "))
third_number = int(input("Введите ваше число: "))
print("Итог: ")
print(first_number in s_array_new)
print(second_number in s_array_new)
print(third_number in s_array_new)
print("Сама серия: ")
print(s_array_new)


print("Задание 10")
array_10 = []
print("Введите 5 чисел в массив: ")
for i in range(5):
    array_10 += list(map(int, input().split()))
for i in range(5):
    if array_10[i] == 0:
        array_10[i] = np.NaN
    else:
        pass
s_array = pd.Series(array_10)
print("Итог: ")
print(s_array)


print("Задание 11")
print(s_array[s_array.notnull()])
print(s_array[s_array.isnull()])


print("Задание 12")
mydict = {'red': 2000, 'blue': 1000, 'yellow': 500, 'orange': 1000}
myseries = pd.Series(mydict)
print(myseries)


print("Задание 13")
colors = ['red','yellow','orange','blue','green']
myseries = pd.Series(mydict, index=colors)
print(myseries)


print("Задание 14")
print(myseries + colors)