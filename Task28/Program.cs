
Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

int multiplication = Mpl(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multiplication}");

int Mpl(int num) 
{
    int mpl = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            mpl *= i; 
        }
    }
    return mpl;
}