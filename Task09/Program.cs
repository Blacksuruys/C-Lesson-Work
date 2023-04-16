//int number = new Random().Next (10,100);
//Console.WriteLine($"Рандомное число в диапазоне 10 - 99 = {number}");
//int firstDigit = number % 10;
//int secondDigit = number / 10;
//if (firstDigit>secondDigit)
//{
//    Console.WriteLine($"Наибольшая цифра в числе = {firstDigit}");
//}
//else
//{
//    
//}
//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine($"Наибольшая цифра в числе = {maxDigit}");


int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int seconDigit = num % 10;
    int maxDigit = firstDigit > seconDigit ? firstDigit : seconDigit;
    return maxDigit;
}

int number = new Random().Next (10,100);
Console.WriteLine($"Рандомное число в диапазоне 10 - 99 = {number}");
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра в числе = {maxDigit}");
