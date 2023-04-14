Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= number)
{
    Console.WriteLine(count + " ");
    count+=2;
}