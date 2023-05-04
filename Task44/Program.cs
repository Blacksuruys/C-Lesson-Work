Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] fibonacci = Fibonacci(number);
PrintArray(fibonacci);

int[] Fibonacci(int size)
{
    int[] array = new int[size];
    // array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}
