// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void PrintArray (int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++) //строки
{
    for (int j = 0; j < matr.GetLength(1); j++) // столбцы
    {
        Console.Write($"{matr[i, j]}");
    }
    Console.WriteLine();
}
}

void FillArray (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(1,10); //интервал от [1,10]
        }
        
    }
}
int [,] matrix = new int [3,4]; /// размерность массива 
//PrintArray(matrix);
//Console.WriteLine();


Console.Write("Введите позицию по строке: \t");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию по столбцу: \t");
int collum = Convert.ToInt32(Console.ReadLine());
FillArray(matrix);
PrintArray(matrix);

string CheckElement(int row, int collum, int[,] matrix)
{
    try
    {
        return $"Значение элемента с индексами {row} {collum} = {matrix[row, collum]}";
    }
    catch
    {
        return "такого числа в массиве нет";
    }
}

Console.WriteLine(CheckElement(row, collum, matrix));








