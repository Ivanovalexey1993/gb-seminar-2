Console.Clear();
void createArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            array[countOne, countTwo] = new Random().Next(0, 11);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1); countTwo++)
        {
            Console.Write(array[countOne, countTwo] + " ");
        }
        Console.WriteLine("");
    }
}

void sortArray(int[,] array)
{
    for (int countOne = 0; countOne < array.GetLength(0); countOne++)
    {
        for (int countTwo = 0; countTwo < array.GetLength(1) - 1; countTwo++)
        {
            for (int countThree = 0; countThree < array.GetLength(1) - 1; countThree++)
            {
                if (array[countOne, countThree] < array[countOne, countThree + 1])
                {
                    int temp = 0;
                    temp = array[countOne, countThree];
                    array[countOne, countThree] = array[countOne, countThree + 1];
                    array[countOne, countThree + 1] = temp;
                }
            }
        }
    }
}

Console.Write("Введите кол-во строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
createArray(array);
Console.WriteLine("Массив: ");
PrintArray(array);
Console.WriteLine("Измененный массив: ");
sortArray(array);
PrintArray(array);