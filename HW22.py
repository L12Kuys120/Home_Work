# Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями). 
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. 
# n — кол-во элементов первого множества. 
# m — кол-во элементов второго множества. Затем пользователь вводит сами элементы множеств.

from random import randint
import numpy as np

print('Введите размер списка n: ')
a = input()
print(f"Строка: {a}")
n = int(a)
print('Введите список состоящий из n членов: ')
nums1 = []
for _ in range(n):
    nums1.append(int(input()))

print('Введите размер списка m: ')
b = input()
print(f"Строка: {b}")
m = int(b)
print('Введите список состоящий из n членов: ')
nums2 = []
for _ in range(m):
    nums2.append(int(input()))
    

anum = np.concatenate((nums1, nums2))
anum1 = sorted(anum)
result = []
[result.append(let) for let in anum1 if let not in result]
# for let in anum1:
#     if let not in result:
#         result.append(let)


print(nums1)
print(nums2)
# print(anum)
# print(anum1)
print(result)


