#Открытие файла
import codecs
afile = codecs.open('D:/GitHub Works/MyLabs/Python works/Lab10.3.txt','r', 'utf_8')

#Основной код
line = 0
for i in afile:
    line += 1
    flag = 0
    word = 0
    for j in i:
        if j != ' ' and flag == 0:
            word += 1
            flag = 1
        elif j == ' ':
            flag = 0
    print(i,len(i),'симв.',word,'сл.')
print(line,'строк.')
afile.close()


