# Задача 32: Определить индексы элементов массива (списка), 
# значения которых принадлежат заданному диапазону 
# (т.е. не меньше заданного минимума и не больше заданного максимума). 
# Список можно задавать рандомно

# На входе : [ 1, 5, 88, 100, 2, -4]
# 33
# 200
# Ответ: [2, 3]

min = 33
max = 200

import random

def RandList(a, b, c):
    sp = [random.randint(a, b) for _ in range(c)]
    return sp

arr = RandList(0, 300, 5)
print(arr)

def Interval(sp):
   
    list = []
    i = 0
    while(i < len(sp)):
 
        if(sp[i] > min and sp[i] < max):           
            list.append(i)
        i = i + 1
    return  list  

print(Interval(arr))