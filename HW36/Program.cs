// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void FillArray(int[] coll)
{
    
    for (int i = 0; i < coll.Length; i++)
    {
        coll[i] = new Random().Next(56);
    }
}

int NotParitySum(int[] coll) 
{
    int result = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if(i % 2 != 0) result += coll[i];
    }   //else result += 0;
    return result;
}


int[] array = new int[6];
FillArray(array);
Console.WriteLine(String.Join(" ", array));
//Console.WriteLine();
int sum = NotParitySum(array);
Console.WriteLine($"NotParitySum = {sum}");