// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");   
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int PlusArray(int[] call)
{
    int result = 0;
    foreach (var item in call)
    {
        result += item > 0 ? 1 : 0;
    }
    return result;
}

int[] baseArray = GetArrayFromString(elements);
Console.WriteLine(String.Join(" ",baseArray));
int sumPlus = PlusArray(baseArray);
Console.WriteLine($"Введено {sumPlus} положительных чисел");