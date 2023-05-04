int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}

void FindSpecificNumber(int rows, int columns, int[,] matrix)
{
    if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1) && rows >= 0 && columns >= 0)
        Console.WriteLine(matrix[rows, columns]);
    else
        Console.WriteLine("Такого элемента в массиве нет");
}

Console.WriteLine("Введите позицию строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrixRndInt(4, 4, -10, 10);
PrintMatrix(matrix);
FindSpecificNumber(row, column, matrix);