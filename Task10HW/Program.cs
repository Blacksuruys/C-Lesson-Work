Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>99 && number<1000)
{
   int result = secondDigit(number);
   Console.WriteLine(result);
}
else
   Console.WriteLine("Вы ввели не трёхзначное число");

int secondDigit(int num)
{
   return num % 100 / 10;
}