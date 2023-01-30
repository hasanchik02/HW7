// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

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

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 10;

Console.Write("Введите индекс строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
int [,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
Printmatrix(array);
if ( a < array.GetLength(0) && b < array.GetLength(1)) Console.WriteLine(array[a,b]);
else Console.WriteLine($"{a},{b} Такого числа нету в массиве");