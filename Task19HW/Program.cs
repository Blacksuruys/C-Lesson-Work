bool Palindrom(int num)
{
    int num5 = num % 10;
    int num1 = num / 10000;
    int num4 = num % 100 / 10;
    int num2 = num / 1000 % 10;
    if ((num5 == num1) && (num4 == num2))
        return true;
    else
        return false;
}

Console.WriteLine("Введите число для проверки на паллиндром: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA < 0) numberA = -numberA;
if (numberA>9999 && numberA<100000)
{
    bool palindrom = Palindrom(numberA);
    Console.WriteLine(palindrom ? "Да" : "Нет");
}
else
    Console.WriteLine("Вы ввели неправильное число");