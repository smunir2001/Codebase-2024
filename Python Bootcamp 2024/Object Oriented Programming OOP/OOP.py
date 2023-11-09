# Sami Munir
# Rutgers University
# smunir2001@gmail.com
# October 25, 2023

# Object Oriented Programming (OOP)

def hello():
    print('\nhello()... called -->')
    print('\thello')

x = 1
print('\ntype(x):', type(x))
print('type(hello):', type(hello))
hello()

x = 1
y = 'hello'
# data type arithmetic error
# print('x + y:', x + y) 

hello = 'Hello, World!'
print('hello:', hello)
print('hello.upper():', hello.upper())

class Car:
    
    def __init__(self, name):
        self.name = name
        self.speed = 0
    
    def getName(self):
        return self.name
    
    def getSpeed(self):
        return self.speed

    def start(self):
        print('\nCar.start() called -->')
        print('\tStarting car...')
    
    def turnOff(self):
        print('\nCar.turnOff() called -->')
        print('\tTurning off car...')
    
    def speedUp(self, speed):
        print(f'\nCar.speedUp({speed}) called -->')
        print(f'\tspeeding up from {self.speed} --> {self.speed + speed}')
        self.speed += speed

    def slowDown(self, speed):
        print(f'\nCar.speedUp({speed}) called -->')
        print(f'\tspeeding up from {self.speed} --> {self.speed - speed}')
        self.speed -= speed

    

honda = Car("Honda Accord")
print('\ntype(honda):', type(honda))
honda.start()
honda.speedUp(25)
honda.speedUp(15)
honda.slowDown(10)
honda.slowDown(30)
honda.turnOff()

class Student:
    def __init__(self, name, age, grade):
        self.name = name
        self.age = age
        self.grade = grade # 0 - 100
    
    def getGrade(self):
        return self.grade

class Course:
    def __init__(self, name, maxStudents):
        self.name = name
        self.maxStudents = maxStudents
        self.students = []
    
    def addStudent(self, student):
        if len(self.students) < self.maxStudents:
            self.students.append(student)
            return True
        return False
    
    def getAverageGrade(self):
        value = 0
        for student in self.students:
            value += student.getGrade()
        return value / len(self.students)
    
    def getStudents(self):
        print('\ncourse.students -->')
        for student in self.students:
            print(student.name)

print()
studentOne = Student('Sam', 19, 95)
studentTwo = Student('Bill', 19, 75)
studentThree = Student('Julie', 20, 80)

courseOne = Course('Computer Science', 2)
courseOne.addStudent(studentOne)
courseOne.addStudent(studentTwo)
courseOne.getStudents()
print('courseOne.getAverageGrade():', courseOne.getAverageGrade())