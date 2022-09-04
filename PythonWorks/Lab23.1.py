import numpy as np
masive1 = np.array([1,2,3,4,5,6,7,8,9,10], int)
print(masive1)

 
#############################################


A = int(input("Введите первое число: "))
for i in range(len(masive1)):
    if masive1[i] == A:
        print(masive1[:i+1])
    else:
        pass
B = int(input("Введите второе число: "))
for i in range(len(masive1)):
    if masive1[i] == B:
        print(masive1[:i+1])
    else:
        pass


#############################################


masive2 = np.array([[1, 2, 3], [4, 5, 6], [7,8,9]], int)
print("***********")
print(masive2)
print("***********")
print("Размеры массива: ", masive2.shape)
user_number1 = int(input("Введите первое число: "))
print(user_number1 in masive2)
user_number2 = int(input("Введите второе число: "))
print(user_number2 in masive2)


#############################################


masive3 = np.array(range(1,31), int)
print(masive3)
masive3_reshape = masive3.reshape((3, 10))
print("**********************")
print(masive3_reshape)
print("**********************")
masive3_reshape = masive3.flatten()
masive2_reshape = masive2.flatten()
masive4 = np.concatenate([masive1, masive2_reshape,masive3_reshape])
print(masive4)


#############################################


masive5 = np.array(range(1,101, 4), int)
print(masive5)


#############################################


matrics1 = np.ones((3,3), dtype=float)
print("**********************")
print(matrics1)
print("**********************")
print(np.zeros_like(matrics1))
print("**********************")


#############################################


masive6 = np.array(range(0,200,2), int)
print(masive6)
print("**********************")
masive6_reshape = masive6.reshape((25,4))
print("**********************")
print(masive6_reshape)


#############################################


print("**********************")
print(np.eye(15, k=7, dtype=float))
print("**********************")
