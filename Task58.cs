// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];
int[,] resultMatrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
InputMatrix(matrix2);
Console.WriteLine();
ReleaseMatrix(resultMatrix);

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i,j]} \t");
        }
            Console.WriteLine();
    }

}

void ReleaseMatrix(int[,] resultMatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultMatrix[i,j]=0;
            for (int k = 0; j < matrix.GetLength(1); j++) 
           {
              resultMatrix[i,j]+= matrix[i, j]*matrix2[i,j];
              Console.Write($"{resultMatrix[i,j]} \t");  
           } 
              Console.WriteLine();  
        }
           
    }

}
