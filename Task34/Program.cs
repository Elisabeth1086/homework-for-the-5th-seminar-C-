// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int CountElements(int[] array, int leftRange, int rightRange)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= leftRange && array[i] <= rightRange)
        {
            count++;
        }
    }
    return count;
}

var myArray = GenerateArray(6, -10, 10);  //граница массива от ..до
PrintArray(myArray);
System.Console.WriteLine(CountElements(myArray, -10, 10));  // диапозон чисел(в каком диапозоне посчитать числа)