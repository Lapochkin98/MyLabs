spisok = [1, 2, 5], [4, 20, 3], [0, 8, 4]

for i in range(len(spisok)):
    s = 0
    for j in range(len(spisok[i])):
        s += spisok[i][j]
    spisok[i][-1::] = [s]

for row in spisok:
    for elem in row:
        print(elem, end=' ')
    print()

