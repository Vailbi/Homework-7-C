// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int [,] matrix = new int[4,5];

void FillArray(int [,] matr) // заполнение матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,15);
            
        }
    }
}

FillArray(matrix);

void PrintArray(int [,] matr) // печать матрицы
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

void ArithmFind (int[,] matr)
{
    double result =0;
    double arithmetic = 0;
    int j =0;
    while (j < matr.GetLength(1))
    {
        for (int i = 0; i < matr.GetLength(0); i++) 
        {
            result = result + matr[i,j];
        }
        arithmetic = result/matr.GetLength(0);
        //Console.WriteLine($"сумма сложения столбика {result} ");
        Console.Write($"{arithmetic} : ");
        result=0;
        j++;
    }
    
}

ArithmFind(matrix);


