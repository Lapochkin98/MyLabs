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
user_n = int(input('Введите N: '))
user_m = int(input('Введите M: '))

matrix = []
for i in range(user_n):
    m_list = []
    for j in range(user_m):
        m_list.append(int(input(f'Введите элемент {i}x{j}: ')))
    matrix.append(m_list)

matrix_end = np.array(matrix)
print(f'Ваша матрица: {matrix_end}')

result = 1
for i in range(user_n):
    if i+1 != user_n:
        result = result * matrix[i][(user_m-1)-(i+1)]
    if i != 0:
        result = result * matrix[i][(user_m-1)-(i-1)]
print(f'Ответ: {result}')

#Задание 3
size = int(input("Введите размер массива: "))
last_array = np.random.randint(-20, 20, size)
print(last_array)
print(np.sort(last_array))