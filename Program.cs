Task47();

Console.ReadKey();
Task50_1();

Console.ReadKey();
Task50_2();

Console.ReadKey();
Task52();


void Task47()
{
    Console.WriteLine("\nЗадача 47. Задайте двумерный массив размером m * n, " +
                        "заполненный случайными вещественными числами.\nПример:" +
                        "\nm = 3, n = 4.\n0,5 7 -2 -0,2\n1 -3,3 8 -9,9\n8 7,8 -7,1 9");

    double[,] martix = CreateAndFillDoubleMatrix(-9, 9);
    PrintDoubleMatrix(martix);
}

void Task50_1()
{
    Console.WriteLine("\nЗадача 50. Напишите программу, которая на вход принимает позиции (индексы) элемента в двумерном " +
                        "массиве и возвращает значение этого элемента или же указание, что такого элемента нет." +
                        "\nНапример, задан массив:\n1 4 7 2\n5 9 2 3\n8 4 2 4\ni = 1, j = 7 -> такого элемента в массиве нет");

    int[,] matrix = CreateAndFillIntMatrix(1, 9);
    PrintIntMatrix(matrix);

    int row = ReadIntFromConsole("Введите индекс строки: ");
    int column = ReadIntFromConsole("Введите индекс столбца: ");

    if (row < matrix.GetLength(0) && column < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент на позиции [{row},{column}] -> {matrix[row, column]}");
    }

    else Console.WriteLine($"Элемента на позиции [{row},{column}] в массиве нет");
}

void Task50_2()
{
    Console.WriteLine("\nЗадача 50. Напишите программу, которая на вход принимает число " +
                        "и возвращает позицию (индексы) одного из таких элементов или же указание, что такого числа нет." +
                        "\nНапример, задан массив:\n1 4 7 2\n5 9 2 3\n8 4 2 4\n17 -> такого числа в массиве нет");

    int[,] matrix = CreateAndFillIntMatrix(0, 9);
    PrintIntMatrix(matrix);

    FindNumberInMatrix(matrix);
}

void Task52()
{
    Console.WriteLine("\nЗадача 52. Задайте двумерный массив из целых чисел. " +
                        "Найдите среднее арифметическое элементов в каждом столбце." +
                        "\nНапример, задан массив:\n1 4 7 2\n5 9 2 3\n8 4 2 4" +
                        "\nСреднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.");

    int[,] matrix = CreateAndFillIntMatrix(0, 9);
    PrintIntMatrix(matrix);

    GetAverageByColumns(matrix);
}


int ReadIntFromConsole(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateAndFillDoubleMatrix(int minVal = -99, int maxVal = 99)
{
    maxVal++;
    Random rand = new Random();

    int rows = ReadIntFromConsole("Введите количество строк: ");
    int columns = ReadIntFromConsole("Введите количество столбцов: ");

    double[,] matrix = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minVal, maxVal) * rand.NextDouble();
        }
    }
    return matrix;
}

void PrintDoubleMatrix(double[,] matrix)
{
    Console.WriteLine("Вывод двумерного массива:");
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(Math.Round(matrix[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

int[,] CreateAndFillIntMatrix(int minVal = -99, int maxVal = 99)
{
    maxVal++;
    Random rand = new Random();

    int rows = ReadIntFromConsole("Введите количество строк: ");
    int columns = ReadIntFromConsole("Введите количество столбцов: ");

    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minVal, maxVal);
        }
    }
    return matrix;
}

void PrintIntMatrix(int[,] matrix)
{
    Console.WriteLine("Вывод двумерного массива:");
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindNumberInMatrix(int[,] matrix)
{
    int find = ReadIntFromConsole("Введите число, которое нужно найти в массиве: ");

    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (find == matrix[i, j])
            {
                Console.WriteLine($"Число {find} находится на позиции -> [{i}, {j}]");
                return;
            }
        }
    }
    Console.WriteLine($"Числа {find} в массиве нет");
}

void GetAverageByColumns(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    Console.WriteLine("Вывод среднего арифметического по столбцам:");

    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, j];
        }
        Console.Write(Math.Round(sum / rows, 2) + "\t");
    }
}
