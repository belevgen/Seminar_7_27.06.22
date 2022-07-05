//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt (string message)
{
    Console.WriteLine(message);
    string intString = Console.ReadLine();
    return int.Parse (intString);
}

void PrintArray (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]:f2}"+"\t");
        }
        Console.WriteLine();
    }
}

double [,] CreateRandomMatrix (int row, int column, int min, int max)
{   
    var rnd = new Random();
    double [,] newMatrix = new double[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newMatrix[i,j] = rnd.Next(min, max+1) + rnd.NextDouble();
        }
    }
    return newMatrix;
}


int n = Prompt ("Введите число строк ");
int m = Prompt ("Введите число столбцов ");
int min = Prompt ("Введите минимум ");
int max = Prompt ("Введите максимум ");

double [,] myArray = CreateRandomMatrix(n, m, min, max);

PrintArray(myArray);