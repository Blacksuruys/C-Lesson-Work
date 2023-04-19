void Cube (int num)
{
   int index = 1;
   while (index <= num)
   {
    Console.WriteLine($"{index , 5}  {index * index * index , 5}");
    index++;
   }
   
}



Console.WriteLine("Введите число для определения x^3");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);

