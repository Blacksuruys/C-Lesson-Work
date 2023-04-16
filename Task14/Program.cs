bool MultiPlice(int num, int num1, int num2)
{
    return (num % num1 == 0) && (num % num2 == 0);
}




Console.WriteLine("Введите число для проверки коатности(7,23)");
int numberA = Convert.ToInt32(Console.ReadLine());
bool result = MultiPlice (numberA,7,23);
Console.WriteLine(result ? "Да" : "Нет");
