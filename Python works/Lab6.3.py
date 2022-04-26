spisok = [1, 2, 5], [4, 20, 3], [0, 8, 4]
#Вывод всего списка
print("Список до сортировки:")
for row in spisok:
    for elem in row:
        print(elem, end=' ')
    print()

#Меняем местами
minIndex = {}
maxIndex = {}
maxNumber = spisok[0][0]
minNumber = spisok[0][0]
for i in range(len(spisok)):
    for j in range(len(spisok[i])):
        if (spisok[i][j] > maxNumber):
            maxNumber = spisok[i][j]
            maxIndex = {'keyX': i, 'keyY': j}
        if (spisok[i][j] < minNumber):
            minNumber = spisok[i][j]
            minIndex = {'keyX': i, 'keyY': j}

        
        #number = max(max(spisok))
        #number1 = min(min(spisok))
print(maxNumber, minNumber)
print(maxIndex)
print(minIndex)
spisok[minIndex['keyX']][minIndex['keyY']] = maxNumber
spisok[maxIndex['keyX']][maxIndex['keyY']] = minNumber

for row in spisok:
    for elem in row:
        print(elem, end=' ')
    print()