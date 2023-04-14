Console.WriteLine ("Введите целое число, для получения диапазона чисел: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = -numberA;
while (count <= numberA)
{
Console.Write(count + " ");
count++;
}