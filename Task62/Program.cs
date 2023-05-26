// Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:

class Program
{
    static void Main(string[] args)
    {
        int[,] spiralArray = new int[4, 4];

        int value = 1;
        int minRow = 0;
        int maxRow = spiralArray.GetLength(0) - 1;
        int minCol = 0;
        int maxCol = spiralArray.GetLength(1) - 1;

        while (value <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
        {
            for (int i = minCol; i <= maxCol; i++)
            {
                spiralArray[minRow, i] = value++;
            }
            minRow++;

            for (int i = minRow; i <= maxRow; i++)
            {
                spiralArray[i, maxCol] = value++;
            }
            maxCol--;

            for (int i = maxCol; i >= minCol; i--)
            {
                spiralArray[maxRow, i] = value++;
            }
            maxRow--;

            for (int i = maxRow; i >= minRow; i--)
            {
                spiralArray[i, minCol] = value++;
            }
            minCol++;
        }

        for (int i = 0; i < spiralArray.GetLength(0); i++)
        {
            for (int j = 0; j < spiralArray.GetLength(1); j++)
            {
                Console.Write("{0:00} ", spiralArray[i, j]);
            }
            Console.WriteLine();
        }
    }
}