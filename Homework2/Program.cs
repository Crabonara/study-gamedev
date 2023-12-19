Console.Write("Кол-во строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());

var matrixA = new int[m, n];

var random = new Random();
for (var i = 0; i < m; i++)
{
    for (var j = 0; j < n; j++)
        matrixA[i, j] = random.Next(1000);
}

int sum = 0;
Console.WriteLine("Матрица A:");
for (var i = 0; i < m; i++)
{
    for (var j = 0; j < n; j++)
    {
        Console.Write($"{matrixA[i, j],5}");
        sum += matrixA[i, j];
    }

    Console.WriteLine();
}

Console.WriteLine($"Сумма всех элементов матрицы A: {sum}");

var matrixB = new int[m, n];

for (var i = 0; i < m; i++)
{
    for (var j = 0; j < n; j++)
        matrixB[i, j] = random.Next(1000);
}

Console.WriteLine("Матрица B:");
for (var i = 0; i < m; i++)
{
    for (var j = 0; j < n; j++)
    {
        Console.Write($"{matrixB[i, j],5}");
    }

    Console.WriteLine();
}
Console.WriteLine($"Сумма матриц A и B:");
var matrixC = new int[m, n];

for (var i = 0; i < m; i++)
{
    for (var j = 0; j < n; j++)
        matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
}

Console.WriteLine("Матрица C:");
for (var i = 0; i < m; i++)
{
    for (var j = 0; j < n; j++)
    {
        Console.Write($"{matrixC[i, j],5}");
    }

    Console.WriteLine();
}