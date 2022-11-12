/*Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого
числа.
456 -> 46
782 -> 72
918 -> 98
*/

Random rnd = new Random();
int number = rnd.Next(100, 1000);
int firstDigit = number / 100; //456/100=4
int secondDigit = number % 10;//456%10=6
Console.WriteLine($"Число от {number} это {firstDigit*10 + secondDigit}");
