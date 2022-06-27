from operator import index
import numpy as np
import pandas as pd

user_columns = dict()
user_data = dict()
data = dict()
print("Введите количество колонок DataFreame: ")
number_columns = int(input())
for i in range(0,number_columns):
    user_columns = input()
    user_data = input()
    data[user_columns] = user_data
print(user_columns)
frame1 = pd.DataFrame(data, index = [0])
print("Ваш DataFrame: ")
print(frame1)
print("А теперь введите индексы")
index_columns = []
for i in range(1,number_columns):
    numbers = input()
    index_columns.append(list(numbers))
print(index_columns)
frame1 = pd.DataFrame(data, index = index_columns)
print(frame1)