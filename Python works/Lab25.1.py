import numpy as np
# N = int(input("Введите размер массива: "))
array = np.array([1,-2,3,0])
print("Ваш массив: ", array)
for i in range(0, len(array)):
    if array[i] > 0:
        array2 = np.array(np.insert(array, i+1, array[i]**2))
print(array2)

