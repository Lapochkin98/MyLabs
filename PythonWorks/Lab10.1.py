#Открытие файла
import codecs
afile = codecs.open('D:/GitHub Works/MyLabs/Python works/Lab10.1.txt','r', 'utf_8')

#Нахождение меньше 3
counter = summa = 0
for line in afile:
    counter += 1
    length_line = len(line)
    for i in range(length_line):
        if line[i].isdigit():
            num = int(line[i])
            summa += num
            if num < 3:
                print("Учащийся, чья оценка по группе меньше 3-х:", line)
            break

#Всего 11 человек #print(counter)
sred = summa / counter
print("Средний бал по группе:", sred)
