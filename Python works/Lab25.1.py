import numpy as np

array = np.array([1,-3,-5,-8])
print("Ваш массив: ", array)
for i in range(0, 6):
    if array[i] < 0:
        array = np.array(np.insert(array, i+1, array[i]**2))
print(array)

