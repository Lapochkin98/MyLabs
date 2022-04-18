spisok = [1, 2, 5], [4, 20, 3], [0, 8, 4]
for row in spisok:
    for elem in row:
        print(elem, end=' ')
    print()
#Вывод первого столбца
print('Первый столбец:')
for row in spisok:
   print(row[0], end = ' ')
print()
#Вывод второго столбца
print('Последний столбец:')
for row in spisok:
   print(row[len(row) - 1], end = ' ')