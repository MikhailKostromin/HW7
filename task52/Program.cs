// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

Console.Write("Введите количество строк: \t");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество по столбцов: \t");
int n = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [m,n]; /// размерность массива 
//PrintArray(matrix);

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();



void FindAverage (int [,] matr)
{
    
    double aver = 0;
    for (int j = 0; j < matr.GetLength(1); j++) //столбцы
    {
    double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++) // строки 
        {
          
          sum = sum + matr[i,j];
          aver= sum/m;
          
        }    
        Console.WriteLine($"Среднее арифметическое по столбцу {j} = {aver}");
    }
     
}
FindAverage(matrix);