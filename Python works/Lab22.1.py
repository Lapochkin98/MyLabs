import requests
import json
def jprint(obj):
    text = json.dumps(obj, sort_keys=True, indent=4)
    print(text)
# Запрос GET (Отправка только URL без параметров)
response_1 = requests.get('http://api.open-notify.org/astros.json')
response_2 = requests.get('https://api.github.com/user')
response_3 = requests.get('https://www.youtube.com/cringe')
print(response_1.status_code)
print(response_2.status_code)
print(response_3.status_code)
jprint(response_1.json())
Type = response_1.headers['Content-Type']
Date = response_1.headers['Date']
Lenght = response_1.headers['Content-Length']
print(Type)
print('Примерная дата: \n' + Date)
print('Длина символов: \n' + Lenght)