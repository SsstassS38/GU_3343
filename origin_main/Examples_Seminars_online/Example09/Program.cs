/*16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.Write("Введите первое число: ");
string numberAStr = Console.ReadLine() ??"";
int numberA = Convert.ToInt32(numberAStr);
Console.Write("Введите второе число: ");
string numberBStr = Console.ReadLine() ??"";
int numberB = Convert.ToInt32(numberBStr);
if(numberA == numberB * numberB || numberB == numberA * numberA)
{
    Console.WriteLine(" одно число является квадратом другого");
}
else
{
    Console.WriteLine(" одно число не является квадратом другого");
}