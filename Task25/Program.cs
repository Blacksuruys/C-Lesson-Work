int Degree(int numA, int numB)
{
    int deg = 1;
    for (int i = 0; i < numB; i++)
    {
        deg = deg * numA;

    }
    return deg;
}

bool ValueB(int b)
{
   if (b<0)
      return false;
   return true;
}


Console.WriteLine("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите возводимую степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int degree = Degree(numberA, numberB);
Console.WriteLine($"Натуральная степень числа = {degree}");
if (ValueB(numberB))
    Console.WriteLine(degree);
    else
    Console.WriteLine("Вы ввели не натуральную степень");
