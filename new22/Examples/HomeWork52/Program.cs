Console.WriteLine("введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[rows, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double sum=0;
for (int j = 0; j < numbers.GetLength(1); j++)
{
       for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum = (sum + numbers[i, j]);
    }
    sum = sum / rows;
    Console.WriteLine($"Среднее арифметическое строки {j}:{sum}; ");
    sum = 0;
}
Console.WriteLine();

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
                for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "; ");
        }   
                Console.WriteLine(""); 
    }
}
