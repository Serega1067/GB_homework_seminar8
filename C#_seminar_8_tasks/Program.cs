/*
Задача 1: 
Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
*/

// Используется в 1 и 2 задаче.
int[,] MakeArray()
{
    Console.WriteLine("Новый двумерный массив\n" +
                      "Введите количество строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[row, column];
    Console.WriteLine("Созданный двумерный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

void SortStringArray(int[,] argArray)
{
    Console.WriteLine("Отсортированный массив: ");
    int temp;
    for (int i = 0; i < argArray.GetLength(0); i++)
    {
        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            temp = argArray[i, j];
            for (int k = j; k < argArray.GetLength(1); k++)
            {
                if (argArray[i, j] < argArray[i, k])
                {
                    temp = argArray[i, k];
                    argArray[i, k] = argArray[i, j];
                    argArray[i, j] = temp;
                }
            }
            Console.Write(argArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
SortStringArray(MakeArray());

/*
Задача 2: 
Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.
*/

/*
int[] FindSumStrings(int[,] argArray)
{
    int sumNumString = 0;
    int[] arraySumNumString = new int[argArray.GetLength(0)];
    for (int i = 0; i < argArray.GetLength(0); i++)
    {
        sumNumString = 0;
        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            sumNumString += argArray[i, j];
        }
        arraySumNumString[i] = sumNumString;
    }
    return arraySumNumString;
}

void FindMinSumString(int[] argArray)
{
    Console.WriteLine("Суммы каждой строки: ");
    int minNumberArray = argArray[0];
    int indMinNumber = 0;
    for (int i = 0; i < argArray.Length; i++)
    {
        if (minNumberArray > argArray[i])
        {
            minNumberArray = argArray[i];
            indMinNumber = i;
        }
        Console.WriteLine(argArray[i] + " ");
    }
    Console.WriteLine("Номер строки с наименьшей суммой: " +
                     $"{indMinNumber + 1}");
}

Console.WriteLine("Задайте прямоугольный двумерный массив");

// Метод MakeArray() взят из 1 задачи.
int[,] binaryArray = MakeArray();
while (binaryArray.GetLength(0) == binaryArray.GetLength(1))
{
    Console.WriteLine("Количество строк и столбцов в прямоугольном " +
                      "двумерном массиве не должно быть одинаково");
    Console.WriteLine("Задайте прямоугольный двумерный массив");
    binaryArray = MakeArray();
}

int[] singleArray = FindSumStrings(binaryArray);
FindMinSumString(singleArray);
*/

/*
Задача 3: 
Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.
*/

/*
int[, ,] MakeArray()
{
    int[, ,] array = new int[2, 2, 2];
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                temp = new Random().Next(10, 100);
                while (CheckingArray(array, temp) == 0)
                {
                    temp = new Random().Next(10, 100);
                }
                array[i, j, k] = temp;
            }
        }
    }
    return array;
}

int CheckingArray(int[, ,] argArray, int argNumber)
{
    int result = 1;
    for (int i = 0; i < argArray.GetLength(0); i++)
    {
        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            for (int k = 0; k < argArray.GetLength(2); k++)
            {
                if (argArray[i, j, k] == argNumber)
                {
                    result = 0;
                }
            }
        }
    }
    return result;
}

void PrintArray(int[, ,] argArray)
{
    Console.WriteLine("Трёхмерный массив: ");
    for (int i = 0; i < argArray.GetLength(0); i++)
    {
        Console.WriteLine("Page " + (i + 1));
        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            for (int k = 0; k < argArray.GetLength(2); k++)
            {
                Console.Write(argArray[i, j, k] + 
                              $" ({i}, {j}, {k}) ");
            }
            Console.WriteLine("\n");
        }
    }
}

PrintArray(MakeArray());
*/

/*
Задача 4: 
Заполните спирально массив 4 на 4.
*/

/*
int[,] FillSpiralArray(int[,] argArray)
{
    int temp, nx, ny;
    int dx = 0;
    int dy = 1;
    int x = 0;
    int y = 0;
    for (int i = 1; i < argArray.GetLength(0) *
                        argArray.GetLength(1) + 1; i++)
    {
        argArray[x, y] = i;
        nx = x + dx;
        ny = y + dy;
        if (nx >= 0 && nx < argArray.GetLength(0) && 
            ny >= 0 && ny < argArray.GetLength(1) && 
            argArray[nx, ny] == 0)
        {
            x = nx;
            y = ny;
        }
        else
        {
            temp = dy;
            dy = -dx;
            dx = temp;
            x = x + dx;
            y = y + dy;
        }
    }
    return argArray;
}

void PrintArray(int[,] argArray)
{
    string whitespace;
    for (int i = 0; i < argArray.GetLength(0); i++)
    {
        for (int j = 0; j < argArray.GetLength(1); j++)
        {
            whitespace = " ";
            if (Convert.ToString(argArray[i, j]).Length == 1)
            {
                whitespace += " ";
            }
            Console.Write(argArray[i, j] + whitespace);
        }
        Console.WriteLine();
    }
}

int[,] squareArray = new int[4, 4];
Console.WriteLine("Спиральный массив размером " +
                  $"{squareArray.GetLength(0)} * " + 
                  $"{squareArray.GetLength(1)}");

PrintArray(FillSpiralArray(squareArray));
*/
