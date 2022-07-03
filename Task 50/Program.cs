// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] matrix = new int[3,5];

void FillArray(int [,] matr) // заполнение матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-99,100);
            
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

Console.WriteLine("Введите число для поиска в массиве: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
FindInMatrix(matrix);


void FindInMatrix(int [,] matr) // поиск числа в массиве по индексу
{
int rows;
int colums;
rows = inputNumber/10;
colums = inputNumber%10;
if (rows > matr.GetLength(0) || colums > matr.GetLength(1))
{
    Console.WriteLine("Нет такого числа в массиве");
}
else
{
    System.Console.WriteLine(matr[rows,colums]);
}
}
