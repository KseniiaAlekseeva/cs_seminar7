// Create a two-dimensional array m*n. Find the odd elements with even indexes and calculate their sum.

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

int SumOddElEvenInd(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            if (array[i, j] % 2 != 0)
            {
                Console.WriteLine($"[{i},{j}]: {array[i, j]}");
                sum += array[i, j];
            }
        }
    }
    return sum;
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

int[,] arr = CreateArray(m, n, 0, 9);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"{SumOddElEvenInd(arr)}");





