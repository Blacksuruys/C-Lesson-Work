int[] array = new int[8];
ArrayIn(array);
ArrayPrint(array);

void ArrayIn(int[] array)
{
   int length = array.Length;
   Random random = new Random();
   for (int i = 0; i < length; i++)
   {
      array[i] = random.Next(0, 100);
   }
}
void ArrayPrint(int[] array)
{
   int length = array.Length;
   for (int i = 0; i < length-1; i++)
   {
      Console.Write($"{array[i]}, ");
   }
   Console.Write($"{array[length-1]} ");
   Console.Write("-> ");
   Console.Write("[");
   for (int i = 0; i < length-1; i++)
   {
      Console.Write($"{array[i]}, ");
   }
   Console.Write($"{array[length - 1]}");
   Console.Write("]");
}