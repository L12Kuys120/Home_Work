# задача 1 необязательная. Напишите программу, которая получает 
# целое число и возвращает его двоичное, восьмеричное строковое представление.
# Функции bin и oct используйте для проверки своего результата.
# *Дополнительно
# Попробуйте избежать дублирования кода в преобразованиях к разным системам счисления
# Избегайте магических чисел
# Добавьте аннотацию типов где это возможно
# Используйте функции

print('Введите число N от 1 до 999:')
n = input()
n1 = int(n)

# print('Введите систему счисления (2, 8):')
# m = input()
# m1 = int(m)

#основания систем счисления
dbin = 2 
doct = 8
def ToNums2(number):
    res = ''
    nums = '012345678'
    while(number > 0):
        res = nums[number % dbin] + res
        number = number//dbin
    return res

def ToNums8(number):
    res = ''
    nums = '012345678'
    while(number > 0):
        res = nums[number % doct] + res
        number = number//doct
    return res


print(ToNums2(n1))
print(ToNums8(n1))



