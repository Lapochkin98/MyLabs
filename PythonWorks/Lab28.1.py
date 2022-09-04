from operator import index
import numpy as np
import pandas as pd

#Задание 1
user_columns = dict()
user_data = dict()
data = dict()
print("Введите количество колонок DataFrame: ")
number_columns = int(input())
for i in range(0,number_columns):
    user_columns = input()
    user_data = input()
    data[user_columns] = user_data
print(user_columns)
frame1 = pd.DataFrame(data, index = [0])
print("Ваш DataFrame: ")
print(frame1)
print("А теперь введите индекс")

#Задание 2
index_columns = []
numbers = input()
index_columns.append(list(numbers))
frame1 = pd.DataFrame(data, index = index_columns)
print(frame1)

#Задание 3
print(frame1.columns)
print(frame1.values)
user_column_data = input(print("Значение какой колонки вывести? "))
print(frame1[user_column_data])

#Задание 4
user_choise = input(print("Выберите строку для вывода (она одна): "))
try:
    print(frame1.loc[user_choise])
except:
    print("Такого индекса нет")

#Задание 5
user_choise1 = input("Введите первый индекс(начало): ")
user_choise2 = input("Введите второй индекс(конец): ")
print(frame1[user_choise1:user_choise2])

#Задание 6
print("А теперь добавим новый столбец: ")
user_new_column = input("Введите имя новой колонки: ")
user_new_data = input("Введите значение нового столбца: ") 
frame1[user_new_column] = user_new_data
print(frame1)

#Задание 7
user_column = input("Введите колонку поиска: ")
user_number = input("Что найти в данной колонке: ")
print((frame1[user_column]==user_number).any())

#Задание 8
user_column = input("Введите колонку для удаления: ")
del frame1[user_column]
print(frame1)

#Задание 9
print(frame1.T)

print("КОНЕЦ ПРОГРАММЫ")
