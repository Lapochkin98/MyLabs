spisok = ['a','b','c','a','a']
print(max(set(spisok), key=lambda x: spisok.count(x)))