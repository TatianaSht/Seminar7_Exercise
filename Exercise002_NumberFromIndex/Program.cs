// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void Main()
{
    int[,] matrix = new int[6, 6];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    int numRow = ReadInt("Введите номер строки: ");
    int numColumn = ReadInt("Введите номер столбца: ");
    FindNumberFromIndex(matrix, numRow, numColumn);
}


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix [i, j]} ");
        }
    Console.WriteLine();
    }
}


int ReadInt (string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


void FindNumberFromIndex(int [,] matrix, int num1, int num2)
{
    if (num1 > matrix.GetLength(0) - 1 | num2 > matrix.GetLength(1) - 1)
    {
         Console.WriteLine($"Позиции с индексом [{num1},{num2}] в данном массиве нет!"); 
    }
    else
    {
        Console.WriteLine($"Значение элемента в позиции [{num1},{num2}]: {matrix [num1, num2]}");
    }
}


Main();

