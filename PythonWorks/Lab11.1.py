class Chocolate:
    def __init__(self, cost,mass,mark):
        self.cost = cost
        self.mass = mass
        self.mark = mark
    def return_info(self):
        print("-------------------------")
        print("Марка: " +self.mark)
        print("Вес: " +self.mass)
        print("Стоимость: " +self.cost)
        print("-------------------------")
    # Деструктор
    def __del__(self):
        print('Объект удалён')

# Создаем экземпляры класса
user_product = Chocolate("300 bucks", "500 г.", "Andreyka")
user_product.return_info()

user_product = Chocolate("1000 bucks", "600 г.", "Nikitka")
user_product.return_info()

user_product.cost = "2000 bucks"
user_product.return_info()