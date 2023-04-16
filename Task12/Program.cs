int MultiplicityNumber(int num1, int num2)
{
    return num1 % num2;  
}





Console.WriteLine("Введите число для проверки кратности");
int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());
int result = MultiplicityNumber(numberOne, numberTwo);
if (result == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine($"Число нечетное = {result}");
}


