Console.WriteLine("Введите желаемое кол-во элементов массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int i=0; i < array.Length; i++)
{
    array[i]= new Random().Next(-10000,10000);
    Console.Write($"{array[i]}, ");
} 
int result=0;
for (int index=1; index<=array.Length-1;)
{
    result = result+array[index]; 
    index = index+2;
    }
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов массива {result}");