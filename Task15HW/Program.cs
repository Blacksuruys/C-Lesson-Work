bool WeekDays(int num)
{
   if(num > 0 && num < 8)
      return true;
   else
      return false;
}
bool DayOff(int num1)
{
   if (num1>5)
      return true;
   else
      return false;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (WeekDays(number))
   if (DayOff(number))
      Console.WriteLine("Да");
   else
      Console.WriteLine("Нет");
else
   Console.WriteLine("Такого дня недели нет.");