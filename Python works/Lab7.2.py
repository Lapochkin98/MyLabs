A = range(1,20+1)
B = range(10,30+1)
C = range(1,21+1, 2)
X1 = set(A)
X2 = set(B)
X3 = set(C)
Y = (X1 | X2) & (X1 | X3) - (X2 | X3)
Y1 = set()
for i in Y:
    if (i % 4 == 0):
        Y1.add(i)
print(Y)
print(Y1)


