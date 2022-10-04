class Target:
    """
    Целевой класс объявляет интерфейс, с которым может работать клиентский код.
    """

    def request(self) -> str:
        return f"На цифровых часах я вижу цифры"


class Adaptee:

    gradus = int(input("Введите количество градусов: "))
    """
    Адаптируемый класс содержит некоторое полезное поведение, но его интерфейс
    несовместим с существующим клиентским кодом. Адаптируемый класс нуждается в
    некоторой доработке, прежде чем клиентский код сможет его использовать.
    """
    def specific_request(self) -> str:
        
        return f"А тут стрелка под углом {self.gradus} градусов"


class Adapter(Target, Adaptee):
    """
    Адаптер делает интерфейс Адаптируемого класса совместимым с целевым
    интерфейсом благодаря множественному наследованию.
    """

    def request(self) -> str:
        Adaptee_gradus = Adaptee.gradus/30
        return f"Adapter: (ADAPTIVED) Стрелка указывает на {Adaptee_gradus} ч."


def client_code(target: "Target") -> None:
    """
    Клиентский код поддерживает все классы, использующие интерфейс Target.
    """

    print(target.request(), end="")


if __name__ == "__main__":
    print("Клиент: Я прекрасно могу работать с объектами Target:")
    target = Target()
    client_code(target)
    print("\n")

    adaptee = Adaptee()
    print("Клиент: Класс Adaptee имеет странный интерфейс. "
          "Видишь ли, я не понимаю:")
    print(f"Adaptee: {adaptee.specific_request()}", end="\n\n")

    print("Клиент: Но я могу работать с ним через Адаптер:")
    adapter = Adapter()
    client_code(adapter)
