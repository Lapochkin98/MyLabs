import math

alphabet = '_АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ' \
           '-абвгдежзийклмнопрстуфхцчшщъыьэюя'


class RSA:
    def __init__(self, p: int, q: int, msg: str):
        self.p: int = p
        self.q: int = q
        self.n = p * q
        self.message: str = msg
        self.coded_message: list[int] = self.__get_code_message()
        self.hashed_message: list[int] = self.__get_hash_message(self.coded_message)

    def __get_code_message(self) -> list[int]:
        coded = []
        message = self.message
        char: str
        for char in message:
            coded.append(
                alphabet.index(char)
            )
        return coded

    def __get_hash_message(self, message: list[int]) -> list[int]:
        hashed = []
        for code in message:
            hashed.append(
                int(math.pow((code + 6), 2) % self.n)
            )
        return hashed


if __name__ == '__main__':
    print ('Лабораторная работа: 7')
    rsa = RSA(
        p=int(input('Введите ваше P: ')),
        q=int(input('Введите ваше Q: ')),
        msg=input('Введите сообщение: ')
    )
    print(f'Ваша хеш-функция: {rsa.hashed_message}')
#p=5; q=9