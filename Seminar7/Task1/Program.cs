// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк в массиве ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве ");
int column = int.Parse(Console.ReadLine());
double[,] array = new double[row, column];
SetArray(array);
Console.WriteLine("Сгенерированный массив (исходный)");
GetArray(array);


double[,] SetArray(double[,] array)
{
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i, j] = Math.Round((new Random().NextDouble()*100), 2);
    }
}
return array;
}

void GetArray(double[,] array)
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
