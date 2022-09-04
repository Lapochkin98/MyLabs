try:
    #Исполняемый код
    coffees =("latte", "cappuccino", "americano")
    coffee1 = sorted(list(coffees[0]))
    coffee2 = sorted(list(coffees[1]))
    coffee3 = sorted(list(coffees[2]))
    #Выполняемый код
    print ('Поиск кофе по названию:')
    coffee_name = input().lower()
    coffee_namelower = sorted(list(coffee_name))
    #Выполнение условия
    if coffee_namelower == coffee1:
        print('Держите ваш любимый кофе - '+ coffees[0]+ ". Он 1-ый по популярности в нашей кофейне.")
    elif coffee_namelower == coffee2:
        print('Держите ваш любимый кофе - '+ coffees[1] + ". Он 2-ой по популярности в нашей кофейне.")
    elif coffee_namelower == coffee3:
        print('Держите ваш любимый кофе - '+ coffees[2]+ ". Он 3-й по популярности в нашей кофейне.")
except:
    print('Такого кофе у нас нету')