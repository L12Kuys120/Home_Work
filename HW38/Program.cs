// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void FillArray(double[] coll)
{
    for (int i = 0; i < coll.Length; i++)
    {
        coll[i] = new Random().Next(0, 100);
    }
}

double MultParNumb(double[] collection)
{
    //int[] mult = new int[collection.Length];
    double min = collection[0];
    
    for (int i = 1; i < collection.Length; i++)
    {
        if(min > collection[i]) min = collection[i];   
    }
   double max = collection[0];
    for (int i = 1; i < collection.Length; i++)
    {
        if(max < collection[i]) max = collection[i];   
    }
    double diff = max - min;
    return diff;


}

double[] array = new double[12];
FillArray(array);
Console.WriteLine(String.Join(" ", array));
double gar = MultParNumb(array);
Console.WriteLine($"Diff = {gar}");

