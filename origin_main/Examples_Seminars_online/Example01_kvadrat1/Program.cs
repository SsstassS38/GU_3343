/* Напишите программу, которая на входе принимает одно число и выдает его квадрат 
(число, умноженное на сома себя)
*/
Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine() ??"";
int number = int.Parse(numberStr);
int result = number * number;
Console.WriteLine($"Квадрат чиcла {number} равен {result}");