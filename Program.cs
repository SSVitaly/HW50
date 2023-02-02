void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-100, 101) / 10.0;
        }
    }
}
Console.WriteLine("Задайте число строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

Console.WriteLine("Создадим массив:");
FillArray(array);
PrintArray(array);

Console.WriteLine("Задайте № строки по порядку искомого элемента:");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте № столбца по порядку искомого элемента:");
int k = Convert.ToInt32(Console.ReadLine());

if (l > array.GetLength(0))
{
    Console.WriteLine("Такого элемента не существует");
}
else if (k > array.GetLength(1))
{
    Console.WriteLine("Такого элемента не существует");
}
else if (l < 1)
{
    Console.WriteLine("Такого элемента не существует");
}
else if (k < 1)
{
    Console.WriteLine("Такого элемента не существует");
}
else
{
    Console.WriteLine($"Искомый элемент: {array[(l - 1), (k - 1)]}");
}
