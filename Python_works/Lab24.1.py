import numpy as np

def SetSize():
    print('Введите размеры таблицы: ')
    i = int(input())
    j = int(input())
    return i, j


first_shag = np.zeros(10)
print(f'******* Упражнение номер 1 *******\n{first_shag}')

second_shag = np.full(40, 4.6)
print(f'******* Упражнение номер 2 *******\n{second_shag}')
 
third_shag = np.arange(50, 1050)
print(f'******* Упражнение номер 3 *******\n{third_shag}')

zadanie4 = third_shag[::-1]
print(f'******* Упражнение номер 4 *******\n{zadanie4}')

zadanie5 = np.arange(200, 399)
print(f'******* Упражнение номер 5 *******\n{zadanie5.transpose()}')

zadanie6 = np.eye(30)
print(f'******* Упражнение номер 6 *******\n{zadanie6}')

zadanie7 = np.random.random((5, 5, 5))
print(f'******* Упражнение номер 7 *******\n{zadanie7}')

zadanie8 = np.ones((SetSize()))
zadanie8[1:-1,1:-1] = 0
print(f'******* Упражнение номер 8 *******\n{zadanie8}')

zadanie9 = np.zeros((SetSize()), dtype = int)
zadanie9[1::2,::2] = 1
zadanie9[::2,1::2] = 1
print(f'******* Упражнение номер 9 *******\n{zadanie9}')