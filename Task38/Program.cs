// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int size, int leftRange, int rightRange)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(leftRange, rightRange + 1)) / 10;
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join("  ", array) + "]");
}

double DiffNum(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    diff = max - min;

    return diff;
}


var myArray = GenerateArray(5, 1, 1000);
PrintArray(myArray);

System.Console.WriteLine($"Разница между максимальным и минимальным элементом равна: {DiffNum(myArray)}");