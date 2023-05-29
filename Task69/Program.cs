
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.



Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int degreeNumbers = DegreeNumbers(numberA, numberB);
Console.WriteLine(degreeNumbers);

int DegreeNumbers(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * DegreeNumbers(numA, numB - 1);
}