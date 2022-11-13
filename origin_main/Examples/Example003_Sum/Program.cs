// Напишите програму которая будет выводить сумму двух случайных чисел от 1 до 10

int numberA = new Random ().Next(1,10);
Console.WriteLine(numberA);
int numberB = new Random ().Next(1,10);
Console.WriteLine(numberB);
int rezult = numberA + numberB;
Console.WriteLine(rezult);