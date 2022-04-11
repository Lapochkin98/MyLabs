txt = "Знание языка залог успеха."
i = 0
for num in txt:
    if i % 3 == 0:
        txt = txt.replace(num,'')
    i+=1
print (txt)