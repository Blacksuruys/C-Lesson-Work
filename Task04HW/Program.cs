Console.WriteLine("Введите три числа, для обнаружения Max: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());
if (numberA > max)
{
    numberA = max;
}
if (numberB > max)
{
    numberB = max;
}
Console.WriteLine($"Максимальное число = {max}");