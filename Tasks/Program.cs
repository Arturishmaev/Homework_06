// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите количество элементов массива: \t");
int elements = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[elements];
System.Console.WriteLine("Введите массив чисел (вводить числа по одной цифре):");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Чисел больше нуля: {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями x = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b1 - b2) / (k2 - k1);
double y = (k2 * x) + b2;
System.Console.WriteLine($"Точка пересечения двух прямых: {x} ; {y}");



