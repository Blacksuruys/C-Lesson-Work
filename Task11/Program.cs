int DelMidDigit (int num)
{
    int num1 = num / 100;
    int num2 = num % 10;
    int delMidDigit = num1 * 10 + num2;
    return delMidDigit;
}

int number = new Random().Next(100,1000);
Console.WriteLine($"3-х значное число = {number}");
int numb = DelMidDigit(number);
Console.WriteLine($"Число после корректировки = {numb}");