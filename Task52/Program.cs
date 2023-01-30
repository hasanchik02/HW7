// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] GetRandomMatrix (int rows, int columns, int leftRange, int rightRange)
{
    int [,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i], 1) + " ");
    }
    Console.WriteLine();
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

int [,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
Printmatrix(array);

double[] avgArray = new double [array.GetLength(1)];

for (int i = 0; i < array.GetLength(1); i++)
{
    double res = 0.0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            res += array[j,i];
        }
    avgArray[i] = res / array.GetLength(0);
} 
PrintArray(avgArray);
