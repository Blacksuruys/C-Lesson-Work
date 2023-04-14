Console.Write("a = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
    Console.WriteLine($"min = {numberB}");
}
else
{
    Console.WriteLine($"min = {numberA}");
    Console.WriteLine($"max = {numberB}");
}
