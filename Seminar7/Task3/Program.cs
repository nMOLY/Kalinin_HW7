// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.WriteLine("Введите количество строк в массиве ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве ");
int column = int.Parse(Console.ReadLine());
int[,] array = new int[row, column];
SetArray(array);
Console.WriteLine("Сгенерированный массив");
GetArray(array);
GetSumOfColumn(array);


int[,] SetArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

void GetArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

void GetSumOfColumn(int[,] array)
{
    for (int i = 0; i < column; i++)
    {
        double ave = 0;
        int sum = 0;
        for (int j = 0; j < row; j++)
        {
            sum += array[j, i];
        }
        ave = (double) sum/row;
        Console.WriteLine($"Ср. арифметическое в {i+1} столбце равно {ave}");
    }
}

