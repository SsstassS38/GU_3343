/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/
Console.WriteLine("Введите два числа: ");
string numberAStr = Console.ReadLine() ??"";
string numberBStr = Console.ReadLine() ??"";
int numberA = int.Parse(numberAStr);
int numberB = int.Parse(numberBStr);
int kvadrat = numberA / numberB;
if(kvadrat == numberB)
{
    Console.WriteLine($"Введенное {numberA} число является квадратом {numberB}");
}
else
{
    Console.WriteLine($"Введенное {numberA} число не является квадратом {numberB}");
}