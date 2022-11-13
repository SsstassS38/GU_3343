/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] InitArray()
{
    int[] result = new int[15];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(99,1000);
    }
    return result;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Result(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((array[i]) % 2 == 0) 
            count = count + 1;           
    }
    return count;
}

int[] array = InitArray();
Print(array);
int counter = Result(array);
Console.WriteLine($"Количество четных чисел в полученном массиве: {counter}");