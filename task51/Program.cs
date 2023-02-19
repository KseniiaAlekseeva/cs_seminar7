// Create a two-dimensional array m*n. Find the sum of diagonal elements.


int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

void ReplaceEvenIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];
    }
}

int SumDiagElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < Math.Min(array.GetLength(0), array.GetLength(1)); i++)
        sum += array[i, i];
    return sum;
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

int[,] arr = CreateArray(m, n, -9, 9);
PrintArray(arr);
Console.WriteLine($"{SumDiagElements(arr)}");


