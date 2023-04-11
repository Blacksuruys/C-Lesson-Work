Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 100) & (number < 999))
{
    Console.WriteLine(number = number % 10);
}
else
{
    Console.WriteLine("Число не трехзначное");
}