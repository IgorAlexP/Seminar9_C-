/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

string NumberRec(int n, int b)
{
    if (n>=b) return $" {n} " + NumberRec(n - 1, b);
    else return string.Empty;
}
Console.WriteLine($"{ n } ->" + NumberRec(n, 1));