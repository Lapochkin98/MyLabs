class BaseClass:
    def __init__(self, pers_name = 'AnonymPlayer', health = 1000, attack = 240, defend = 30):
        self.pers_name = pers_name
        self.health = health
        self.attack = attack
        self.defend = defend
    def info_base(self):
        print("****************")
        print('Привет, моё имя ' + self.pers_name)
        print('***')
        print("Здоровье:",self.health)
        print("Атака:", self.attack)
        print("Защита:",self.defend)
        print('***')

class BaseMag(BaseClass):
    def __init__(self, pers_name, health, attack, defend):
        super().__init__(pers_name, health, attack, defend)
        self.attack = attack * 1.20
    def say_info(self):
        print("Вы выбрали класс: Маг")
        BaseClass.info_base(self)

class BaseWar(BaseClass):
    def __init__(self, pers_name, health, attack, defend):
        super().__init__(pers_name, health, attack, defend)
        self.health = health * 1.50
    def say_info(self):
        print("Вы выбрали класс: Воин")
        BaseClass.info_base(self)
class BaseHeal:
    def __init__(self, pers_name, health, attack, defend):
        super().__init__(pers_name, health, attack, defend)
        self.defend = defend * 1.1
    def say_info(self):
        print("Вы выбрали класс: Целитель")
        BaseClass.info_base(self)

class BetterBase(BaseClass):
    user_element = 'None'
    def __init__(self, pers_name, health, attack, defend):
        super().__init__(self, pers_name, health, attack, defend)
        self.krit_attack = 10
        self.avoidance = 15
    def new_info(self):
        BaseClass.info_base(self)
        print("Крит.урон: ", self.krit_attack)
        print("Уклонение: ", self.avoidance)
        print("Стихия: ", element)

class BetterMag(BaseMag,BetterBase):
    def __init__(self, pers_name = 'AnonymPlayer', health = 1000, attack = 240 * 1.2, defend = 30, krit_attack = 10, avoidance = 15):
        BaseMag.__init__(self, pers_name, health, attack, defend)
        BetterBase.__init__(self)
        self.pers_name = pers_name
        self.health = health
        self.attack = attack * 1.20
        self.defend = defend
        self.krit_attack = krit_attack
        self.avoidance = avoidance
    def say_info(self):
        BetterBase.new_info(self)
class BetterWar(BaseWar,BetterBase):
    def __init__(self, pers_name = 'AnonymPlayer', health = 1000 * 1.50, attack = 240, defend = 30, krit_attack = 10, avoidance = 15):
        self.pers_name = pers_name
        self.health = health * 1.50
        self.attack = attack
        self.defend = defend
        self.krit_attack = krit_attack
        self.avoidance = avoidance
    def say_info(self):
        BetterBase.new_info(self)
class BetterHeal(BaseHeal,BetterBase):
    def __init__(self, pers_name = 'AnonymPlayer', health = 1000, attack = 240, defend = 30 * 1.1, krit_attack = 10, avoidance = 15):
        self.pers_name = pers_name
        self.health = health
        self.attack = attack
        self.defend = defend * 1.1
        self.krit_attack = krit_attack
        self.avoidance = avoidance
    def say_info(self):
        BetterBase.new_info(self)


pers_name = input("Введите имя вашего персонажа: ")
user_class = input("Выберите класс: Маг(mag), Воин(war), Целитель(heal): ")
if user_class == 'mag':
    pers_obj = BaseMag(pers_name)
    pers_obj.say_info()
    better_user_class = input('Вы хотите улучшить своего персонажа?(Y/N) ')
    if better_user_class == 'Y':
        element = input('Введите стихию: ')
        better_mag = BetterMag(pers_name)
        better_mag.user_element = element
        better_mag.say_info()
    elif better_user_class == 'N':
        pass
    else:
        print('Ошибка ввода')
elif user_class == 'war':
    pers_obj = BaseWar(pers_name)
    pers_obj.say_info()
    better_user_class = input('Вы хотите улучшить своего персонажа?(Y/N) ')
    if better_user_class == 'Y':
        element = input('Введите стихию: ')
        better_mag = BetterWar(pers_name)
        better_mag.user_element = element
        better_mag.say_info()
    elif better_user_class == 'N':
        pass
    else:
        print('Ошибка ввода')
elif user_class == 'heal':
    pers_obj = BaseHeal(pers_name)
    pers_obj.say_info()
    better_user_class = input('Вы хотите улучшить своего персонажа?(Y/N) ')
    if better_user_class == 'Y':
        element = input('Введите стихию: ')
        better_mag = BetterHeal(pers_name)
        better_mag.user_element = element
        better_mag.say_info()
    elif better_user_class == 'N':
        pass
    else:
        print('Ошибка ввода')
else:
    print('Ошибка ввода')