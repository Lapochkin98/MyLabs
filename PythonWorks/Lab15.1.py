import codecs

class Group:
    college_name = "ВГПК"
    student_count = 0
    student_spisok = []
    avg_mark = 0
    def __init__(self,group_name, kurs):
        self.group_name = group_name
        self.kurs = kurs
    def __getattr__(self, attr):
        return "Такового поля нет!"
    def __setattr__(self, attr, value):
        if attr == 'college_name':
            print('Вы не можете изменить данное поле: ' + self.college_name)
        else:
            self.__dict__[attr] = value
    def __str__(self):
        txt = str(self.college_name) + "\nЭто "+ str(self.group_name) + "\nКурс: " + str(self.kurs) +  "\nКоличество студентов: " + "[" + str(self.student_count)+ "]" + "\nСписок студентов"+ str(self.student_spisok) + "\nСредняя оценка: " + str(self.avg_mark)
        return txt
    def __delattr__(self, attr):
        print("Данное поле удалить нельзя")
    def setStudents(self, filename):
        afile = codecs.open(rf'D:/GitHub Works/MyLabs/Python works/{filename}','r', 'utf_8')
        for line in afile:
            self.student_spisok.append(line.rstrip())
            self.student_count+=1
        
        


pz = Group("ПЗ-55", "2")
print(pz)
pz.group_name = "ПЗ-56"
pz.college_name = "ВГУ"
print(pz)
print(pz.lalala)
del pz.avg_mark
pz.setStudents("lab10.3.txt")
print(pz)
tempMark = 0
for i in range(0, len(pz.student_spisok)):
    print("Введите оценку", pz.student_spisok[i])
    tempMark +=int(input())
pz.avg_mark = tempMark / pz.student_count
print(pz)