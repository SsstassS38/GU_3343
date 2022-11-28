/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int Numbers(int a, int b)
{
    if (a == b)
        return a;
    else
        Console.Write($"{Numbers(a, b + 1)}, ");
    return b;
}

int InputA(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int a = InputA("Введите положительное число");
int b = 1;
if (a < 1)
{
    Console.WriteLine("Введено не положительное число");
}
Console.WriteLine(Numbers(a, b));