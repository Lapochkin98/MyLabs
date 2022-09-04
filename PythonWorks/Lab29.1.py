import pandas as pd
import numpy as np

def New_data_frame(x,y):
    elements_List = []
    indexList = []
    columnList = []
    for i in range(1, x+1):
        element_List = []
        for j in range(1, y+1):
            element_List.append(int(input(f'Элемент {i}x{j}: ')))
        elements_List.append(element_List)
    for i in range(1, x+1):
        indexList.append(input(f'Индекс {i}: '))
    for j in range(1, y+1):
        columnList.append(input(f'Столбик {j}: '))
    New_frame = pd.DataFrame(elements_List, index = indexList, columns = columnList)
    print(New_frame)
    user_drop_str = input("Какую строку вы хотите удалить: ")
    print(New_frame.drop(user_drop_str))
    user_drop_column = input("Какую колонку удалить? ")
    print(New_frame.drop([user_drop_column],axis=1))

print("Введите x: ")
x = int(input())
print("Введите y:")
y = int(input())
New_data_frame(x,y)
