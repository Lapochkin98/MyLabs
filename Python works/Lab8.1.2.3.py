task = int(input('Выберите номер задания: '))
if (task == 1):
    #Задание 1
    school = {
        '1a' : 21,
        '1b' : 25,
        '2c' : 30,
        '3d' : 23,
        '1f' : 24
    }
    print(school)
elif (task == 2):
    #Задание 2
    school = {
        '1a' : 21,
        '1b' : 25,
        '2c' : 30,
        '3d' : 23,
        '1f' : 24
    }
    class_name = input('Введите номер класса чтобы узнать к-во учеников: ')
    if class_name in school:
        print(school.get(class_name))
    else:
        print('Такого класса не существует!')
elif (task == 3):
    #Задание 3
    dictionary_1 = {'a': 300, 'b': 400}
    dictionary_2 = {'c': 500, 'd': 600}
    dictionary_1.update(dictionary_2)
    print(dictionary_1)
