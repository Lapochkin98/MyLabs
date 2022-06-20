import numpy as np
import math
import random

#Задание 1
n = int(input("Введите размер массивов: "))
first_array = np.array(range(0,n+1))
second_array = np.array(range(n, 2*n+1))
print("Сумма равна: ", first_array+second_array)
print("Разность равна: ", first_array-second_array)
print("Произведение равно: ", first_array*second_array)

third_array = np.random.randint(-20, 10, 50)
sum = 0
sum = np.sum(third_array)
print("Сумма: ", sum)
print("Максимальный элемент: ", third_array.max())
print("Минимальный элемент: ", third_array.min())
print("Уникальные элементы: ", np.unique(third_array))

thirth_array = np.ones((n,n),  dtype = float)
print("Определитель матрицы: ",np.linalg.det(thirth_array))
vals, vecs = np.linalg.eig(thirth_array)
print(vals)
print(vecs)

#Задание 2


#Задание 3
size = int(input("Введите размер массива: "))
last_array = np.random.randint(-20, 20, size)
print(last_array)
print(np.sort(last_array))