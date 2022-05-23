from math import pi
class Sphere:
    def __init__(self, *arg):
        if len(arg) == 0:
            arg = (1, 0, 0, 0)
            print('---------------------')
            print('Аргументы отсутствуют')
            print(arg)
            print('---------------------')
        elif len(arg) == 1:
            arg = (arg[0], 0, 0, 0)
            print('---------------------')
            print('Один аргумент')
            print(arg)
            print('---------------------')
        else:
            print('Что-то не так!')
        self.radius, self.x_cord, self.y_cord, self.z_cord = arg
#Объём шара
    def get_volume(self):
        return (self.radius ** 3) * pi * 4 / 3
#Площадь внешней поверхности сферы
    def get_square(self):
        return (self.radius ** 2) * pi * 4
#Радиус сферы
    def get_radius(self):
        return (self.radius)
#Три координаты
    def get_center(self):
        return (self.x_cord, self.y_cord, self.z_cord)
#Меняет радиус
    def set_radius(self, radius):
        self.radius = radius
#Меняет координаты центра сферы
    def set_center(self, x_cord, y_cord, z_cord):
        self.x_cord = x_cord
        self.y_cord = y_cord
        self.z_cord = z_cord
#Возвращает логическое значение True или False
    def is_point_inside(self,x_cord, y_cord, z_cord):
        return (self.x_cord-x_cord)**2 + (self.y_cord-y_cord)**2 + (self.z_cord-z_cord)**2 < self.radius**2
# Деструктор
    def __del__(self):
        print("Bceм пока!")

user_Sphere =  Sphere()
user_Sphere =  Sphere(23)

user_Sphere = Sphere(23,4,5,6)
print('---------------------')
print(user_Sphere.get_volume())
print('---------------------')
print(user_Sphere.get_square())
print('---------------------')
print(user_Sphere.get_radius())
print('---------------------')
print(user_Sphere.get_center())
print('---------------------')
user_Sphere.set_center(4,4,4)
print('---------------------')
print(user_Sphere.is_point_inside(4,4,4))
print('---------------------')