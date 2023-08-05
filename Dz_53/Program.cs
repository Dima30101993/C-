// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max) 
{
    double[] arr = new double[size];
    
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        double roundNum = Math.Round(arr[i], 1);
       if(i < arr.Length - 1) Console.Write($"{roundNum}; ");
       else Console.Write($"{roundNum}");
    }
    Console.Write("]");
}

double MaxElementArray(double[] arr)
{
    double arrayMax = arr.Max();
    return arrayMax;
}

double MinElementArray(double[] arr)
{
    double arrayMin = arr.Min();
    return arrayMin;
}

double[] array = CreateArrayRndDouble(10, 0, 100);
PrintArray(array);
Console.WriteLine();

double maxElement = MaxElementArray(array);
double minElement = MinElementArray(array);
double difference = Math.Round((maxElement - minElement), 1);
Console.WriteLine($"Разница между максимальными и минимальным элементом массива = {difference}");
