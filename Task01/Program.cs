﻿Console.WriteLine("Введите целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int numberB = Convert.ToInt32(Console.ReadLine());
if ((numberA == numberB * numberB) | (numberB == numberA* numberA)){
    Console.WriteLine("ДА");
}
else {
    Console.WriteLine("НЕТ");}
