def is_year_leap(year):
   if year % 4 != 0:
       return False
   elif year % 100 == 0:
       if year % 400 == 0:
           return True
       else:
           return False
   else:
       return True
def date(day, month, year):
# Задаем количество дней в месяцах невисокосного года
   set_months = {1 : 31,
                 2 : 28,
                 3 : 31,
                 4 : 30,
                 5 : 31,
                 6 : 30,
                 7 : 31,
                 8 : 31,
                 9 : 30,
                 10 : 31,
                 11 : 30,
                 12 : 31}

# Проверяем заданы ли верно год и месяц
   if year > 0 and (month >= 1 and month <= 12):
# Изменяем количество дней для февраля в високосных годах
       if month == 2 and is_year_leap(year) == True:
           set_months[2] = 29
# Проверяем задан ли верно день
       if day in range(1, set_months[month]+1):
           return True
       else:
           return False
   else:
       return False
# Тест кейсы
day = int(input('День: ')) #int(input('Сумма вклада: '))
month = int(input('Месяц: '))
year = int(input('Год: '))
print(date(day, month, year)) # Проверка даты
