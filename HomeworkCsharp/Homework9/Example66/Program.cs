/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int Input(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int NaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + NaturalSum(m, n - 1);
}

int m = Input("Введите число M: ");
int n = Input("Введите число N: ");
Console.WriteLine($"Сумма натуральных эл-ов от {m} до {n} = {NaturalSum(m, n)}");
