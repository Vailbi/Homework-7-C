// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.


Console.WriteLine("Введите количетсво строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double[m,n];


void FillArray(double [,] matr) // заполнение матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-99,100);
            matr[i,j] = matr[i,j]/10;
        }
    }
}
FillArray(matrix);
void PrintArray(double [,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++) 
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"{matr[i,j]} ");
    }
Console.WriteLine();
}
}

PrintArray(matrix);

