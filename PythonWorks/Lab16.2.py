def decorator_numbers(numbers_class):
    class numbers2(numbers_class):
        def __init__(self, a, b):
            self.a = a
            self.b = b
        def division(self):
            if self.a == 0 or self.b ==0:
                return "Делить на ноль нельзя"
            else:
                division = self.a / self.b
                return division
        def multiplication(self):
            multiplication = self.a * self.b
            return multiplication
    return numbers2


@decorator_numbers
class numbers1:
    def __init__(self, a, b):
        self.a = a
        self.b = b
    def sum(self):
        sum = self.a + self.b
        return sum
    def minus(self):
        minus = self.a - self.b
        return minus


def operation(operation = False):
    while operation == False:
        order = input('Для работы A с B, используйте (1) \nА для B с A, используйте (2): ')
        if order == '1' or order == '2':
            operation = int(order)
        else:
            operation = False
            print('Произошла ошибка!')
    return operation


a = int(input("Введите a: "))
b = int(input('Введите b: '))
compute = numbers1(a, b) if operation() == 1 else numbers1(b, a)
print('Сумма: ' + str(compute.sum()))
print('Разность: ' + str(compute.minus()))
print('Частное: ' + str(compute.division()))
print('Произведение: ' + str(compute.multiplication()))