/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] InitArray()
{
    int[] result = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 10);
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

int GetPositiveSumm(int[] array)
{
    int positiveSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
            positiveSumm+= array[i];
    }
    return positiveSumm;
}
int[] array = InitArray();
Print(array);
int positiveSumm = GetPositiveSumm(array);
Console.WriteLine($"Сумма элементов на нечетных позициях равно:{positiveSumm}");