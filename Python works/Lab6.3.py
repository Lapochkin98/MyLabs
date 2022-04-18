spisok = [1, 2, 5], [4, 20, 3], [0, 8, 4]
index_of_max = 0
index_of_min = 0
#Вывод всего списка
print("Список до сортировки:")
for row in spisok:
    for elem in row:
        print(elem, end=' ')
    print()

#Меняем местами
for row in spisok:
    for elem in row:
        number = max(max(spisok))
        number1 = min(min(spisok))
spisok[0].insert(spisok.index(number),number1)
spisok.remove(number)
spisok[1].insert(spisok.index(number),number1)
spisok.remove(number)
spisok[2].insert(spisok.index(number),number1)
spisok.remove(number)
spisok[0].insert(spisok.index(number1),number)
spisok[1].insert(spisok.index(number1),number)
spisok[2].insert(spisok.index(number1),number)
print(number)
print(number1)
