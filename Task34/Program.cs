// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = CreateArrayRndInt(4);
PrintArray(array);
int evenNumbersAmount = EvenNumbersAmount(array);
Console.Write($"Количество чётных чисел в массиве = {evenNumbersAmount}");

int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 999 + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int EvenNumbersAmount(int[] arr)
{
    int evenNumbersAmount = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] % 2 == 0) evenNumbersAmount++;
    }
    return evenNumbersAmount;
}