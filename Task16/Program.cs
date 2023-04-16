bool Sqare (int numA, int numB)
{
    return (numA == numB * numB) || (numB ==numA * numA);
}




Console.WriteLine("Enter your number");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
bool result = Sqare(numberA,numberB);
Console.WriteLine(result ? "Yes" : "No");
