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

bool CheckNumber(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

Console.WriteLine("Please enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt(5, 1, 90);
Console.Write("[");
PrintArray(array);
Console.Write("]");
bool checkNumber = CheckNumber(number, array);
Console.WriteLine();
Console.WriteLine(checkNumber ? "Есть соответствие" : "Соответствия нет");