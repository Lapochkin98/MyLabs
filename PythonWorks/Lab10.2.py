#Открытие файла
import codecs
afile = codecs.open('D:/GitHub Works/MyLabs/Python works/Lab10.2.txt','w', 'utf_8')

#Основной код
while True:
    user_word = input('Введите ваше слово: ')
    if user_word == '':
        afile.close()
        break
    else:
        afile.write(user_word + '\n')
