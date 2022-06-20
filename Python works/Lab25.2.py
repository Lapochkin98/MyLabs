import numpy  as np
import codecs

#$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$#
afile = codecs.open(rf'C:/Users/dorak/Documents/GitHub/MyLabs/Python works/list.txt','w', 'utf_8')
array1 = np.zeros(10)
array2 = np.zeros(55)
print("Задание 1: ")
print(array1)
print(array2)
a = np.eye(5, k=0, dtype=float)
a[a == 0] = 2
print("Задание 2: ")
print(a)
#$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$#
array3 = np.ones(25)
# array3 = array3.reshape(5,5)
array3[:5] = range(1,6)
array3[5:10] = range(1,6)
array3[10:15] = range(1,6)
array3[15:20] = range(1,6)
array3[20:25] = range(1,6)
array3 = array3.reshape(5,5)
print("Задание 3: ")
print(array3)
array3_str = str(array3)
a_str = str(a)
try:
   afile.write("\nЗадание 1:\n")
   afile.write(a_str)
   afile.write("\nЗадание 2:\n")
   afile.write(array3_str)
finally:
    print("Успешный перенос, проверьте файл")
