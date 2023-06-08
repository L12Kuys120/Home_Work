// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//- b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите параметры прямых y = kx + b :");
Console.WriteLine("Введите последовательно k1 и b1:");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последовательно k2 и b2:");
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());

double[] SolvEquat(double a, double b, double c, double d)
{   
    double[] solv = new double[2];
    solv[0] = (d - b)/(a - c);
    solv[1] = a * solv[0]+ b;
    return solv;
}
 double[] res = SolvEquat(k1, b1, k2, b2);
Console.WriteLine(String.Join(" ",res));
