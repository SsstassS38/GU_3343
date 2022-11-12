﻿/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число N: ");
String numberStrN = Console.ReadLine() ??"";
int numberN = Convert.ToInt32(numberStrN);

int SumNumber(int numberN){
    
    int count = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine($"Сумма цифр в введенном числе: {sumNumber}");