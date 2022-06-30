groups = tuple(range(1, 5+1))
names = ("Аниськов", "Самойлов", "Костенко", "Шумель", "Ковзель", "Дубровский")
print("Студент под пятым номером ", names[5])
print("Элемент второго кортежа с номером 5 ", names[5])
journal = names+groups
print(journal)
srez = journal[2:-2]
print(srez)