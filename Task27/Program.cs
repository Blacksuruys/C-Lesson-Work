Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int valueDigits = ValueDigits(number);
int result = SumDigits(valueDigits);
Console.WriteLine(result);

int SumDigits(int num)
{
   int sum = 0;
   while (num>0)
   {
      sum += num % 10;
      num /= 10;
   }
      
   return sum;
}
int ValueDigits(int num)
{
   if (num<0)
      return -num;
   return num;
}

