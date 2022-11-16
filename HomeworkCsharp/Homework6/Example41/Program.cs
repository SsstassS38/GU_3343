// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetPositive(int[] array)
{
    int positiveSumm = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
            positiveSumm+= array[i];
    }  
    return positiveSumm;
}
int[] array =;
PrintArray(array);
int positiveSumm = GetPositive(array);
Console.WriteLine($"Сумма положительных чисел: {positiveSumm},");

