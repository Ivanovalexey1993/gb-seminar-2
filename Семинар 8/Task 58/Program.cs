//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размер матриц: ");
int[,] matrixX = new int[size, size];
int[,] matrixY = new int[size, size];
FillArrayRandomNumbers(matrixX);
FillArrayRandomNumbers(matrixY);
int[,] matrixZ = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixZ[i, j] = matrixZ[i, j] + (matrixX[i, k] * matrixY[k, j]);
        }
    }
}
Console.WriteLine("Матрица - X");
PrintArray(matrixX);
Console.WriteLine();
Console.WriteLine("Матрица - Y");
PrintArray(matrixY);
Console.WriteLine();
Console.WriteLine("X*Y");
PrintArray(matrixZ);