
import string
import random

def generate_random_password(user_count_number):
    special_symbols = "!~}|{'_^]\[@?>=<;:/.-,+*)('&%$#"
    rus_little_letters = "йцукенгшщзхъфывапролджэячсмитьбюё"
    letters = special_symbols+rus_little_letters
    rand_string = ''.join(random.choice(letters) for i in range(user_count_number))
    print("Случайно сгенерированный пароль: ", rand_string)

try:
    A = 66
    S = (4.34524 * 1.42857) / 0.0001
    print("Введите количество символов в пароле: ")
    user_count_number = int(input())
    print("Ваша A = " + str(A))
    print("S = " + str(S))
    print("A^L = ", A**user_count_number)
    
    if (S <= A**user_count_number):
        print("Условие A>=S* - выполняется")
        generate_random_password(user_count_number)
    else: 
        print("Условие A>=S* - нарушено, поробуйте ещё раз")
        
except:
    print("Произошла ошибка!")
