// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void PrintArray (double[,] matr)
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

void FillArray (double [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(-10,10)+new Random().NextDouble();;  
           // new Random().Next(0, 10) - создаст случайное целое число от 1 до 10
           // new Random().NextDouble() - добавит случайную дробную часть
        }
        
    }
}
double [,] matrix = new double [3,4]; // размерность масива 
//PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

