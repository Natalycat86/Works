
void f_2_arr(int[,] arr, int min, int max) // запись массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}
void write_2_arr(int[,] arr) // вывод массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите размерность массива (m): ");

    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите размерность массива (n): ");

    int n = int.Parse(Console.ReadLine());
    int[,] arr = new int[m, n];

    f_2_arr(arr, 1, 10);
    write_2_arr(arr);

    int sum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i < arr.GetLength(1))
        {
            Console.Write($"{arr[i, i]} ");
            sum += arr[i, i];
        }
        else
        {
            break;
        }
        Console.Write("+ ");
    }

    Console.WriteLine($"= {sum}");
