﻿Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (ValidateNumber(number))
   Console.WriteLine(GetThreeDigitNumber(number));
else
   Console.WriteLine("Вы ввели число < 100");

int GetThreeDigitNumber(int num)
{
   while (num>999)
      num = num / 10;
   return num % 10;
   }
bool ValidateNumber(int num1)
{
   if (num1<100)
      return false;
   else
      return true;
}

