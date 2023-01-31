// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите число a:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число c:");
double c = Convert.ToDouble(Console.ReadLine());

double[] namber = { a, b, c };

int i = 1;
double max = a;

while (i < 3)
{
    if (namber[i] > max)
    {
        max = namber[i];
    }
    i++;
}
Console.WriteLine("Максимальное число:" + max);


