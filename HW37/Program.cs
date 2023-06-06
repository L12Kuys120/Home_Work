// Задача 37. Найдите произведение пар чисел в одномерном массиве.
//Парой считается 1-й и последний элемент, 2-й и предпоследний и т.д.
//Результат запишите в новом мвссиве.
//[1, 2, 3, 4, 5] -> [5, 8, 3]
//[6, 7, 3, 6] -> [36, 21]

void FillArray(int[] coll)
{
    for (int i = 0; i < coll.Length; i++)
    {
        coll[i] = new Random().Next(10);
    }
}

int[] MultParNumb(int[] collection)
{
    int[] mult = new int[collection.Length/2];
    for (int i = 0; i < (collection.Length/2); i++)
    {
        mult[i] = collection[i] * collection[collection.Length - 1 - i];        
    }
    return mult;
}

int[] array = new int[12];
FillArray(array);
Console.WriteLine(String.Join(" ", array));
int[] call = MultParNumb(array);
Console.Write(String.Join( " ", call));
