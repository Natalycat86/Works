Console.WriteLine("Задайте размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;
int[,] numbers = new int[rows, columns];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Исходный массив:"); 
PrintArray(numbers);
int sum=0;
int []summs = new int[columns];
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1);)
    {
    sum = (sum + numbers[i, j]);    
    summs[j] = sum;
    j++;
    }
    Console.WriteLine($"Сумма строки {i}:{sum}; ");
    sum = 0;
   }

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