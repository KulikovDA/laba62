//базовый 3
try
{
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());

    int[,] matrix = new int[n, m];
    int[] columnSums = new int[m];

    Console.WriteLine("Введите элементы матрицы:");

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = int.Parse(Console.ReadLine());
            columnSums[j] += matrix[i, j];
        }
    }

    Console.WriteLine("Суммы элементов столбцов:");

    for (int j = 0; j < m; j++)
    {
        Console.WriteLine($"Сумма столбца {j + 1}: {columnSums[j]}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
