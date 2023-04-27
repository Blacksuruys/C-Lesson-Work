int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int SumPositiveElrmrnts(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int SumNegativElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}


int[] array = CreateArrayRndInt(12, -9, 9);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();
int sumPos = SumPositiveElrmrnts(array);
int sumNeg = SumNegativElements(array);
Console.WriteLine($"Сумма положительных чисел в массиве равна = {sumPos}");
Console.WriteLine($"Сумма отрицательных чисел в массиве равна = {sumNeg}");
