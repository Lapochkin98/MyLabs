class Vector:
    def __init__(self, name, x , y):
        self.name = name
        self.x = x
        self.y = y
    def __str__(self):
        txt = "вектор " + str(self.name) + ": " + "(" + str(self.x) + ", " + str(self.y) + ")"
        return txt
    def __add__(self, other):
            return Vector("SumVector", int(self.x) + int(other.x), int(self.y) + int(other.y))

    def __sub__(self, other):
        if isinstance(other, Vector):
            SubVector = Vector("SubVector", int(self.x) - int(other.x), int(self.y) - int(other.y))
            return SubVector
        else:
            pass
    def __mul__(self, other):
        return Vector("MulVector", int(self.x) * other, int(self.y) * other)
    def __eq__(self, other):
        if  int(self.x) == int(other.x) and int(self.y) == int(other.y):
            return "равны"
        else:
            return "не равны"
name = input("Введите название вектора: ")
x = input("Введите первую координату: ")
y = input("Введите вторую координату: ")
user_vector = Vector(name, x, y)
print("Вы создали", user_vector)
name2 = input("Введите название вектора:")
x2 = input("Введите первую координату:")
y2 = input("Введите вторую координату:")
user_vector2 = Vector(name2, x2, y2)
print("Вы создали", user_vector2)
vectorSum = user_vector + user_vector2
print("Сумма = ", vectorSum)
vectorSub = user_vector - user_vector2
print("Разность = ", vectorSub)
user_num = int(input("Введите число: "))
vectorMul = user_vector * user_num
print("Вектора на число = ", vectorMul)
print("Вектора", user_vector == user_vector2)