//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк в массиве ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве ");
int column = int.Parse(Console.ReadLine());
int[,] array = new int[row, column];
SetArray(array);
Console.WriteLine("Сгенерированный массив (исходный)");
GetArray(array);
Console.WriteLine("Введите число для поиска");
int toFind = int.Parse(Console.ReadLine());
GetNumber(array, toFind);

int[,] SetArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 101);
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

void GetNumber(int[,] array, int toFind)
{
    bool istrue = false;
    int x=0, y=0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (array[i, j] == toFind)
            {
                istrue = true;
                x = i;
                y = j;
                break;
            };
        }
    }
    if (istrue) Console.WriteLine($"Да, заданное число входит в двумерный массив под номером [{x}, {y}]");
    else Console.WriteLine("Нет, такого числа в массиве нет");
}