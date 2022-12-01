Console.WriteLine("Введите числа разделяя их запятой");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = {1, 5, 99, 33, 45, 118, 30};
for (int i=0; i < array.Length; i++)
{
        Console.Write($"{array[i]}, ");
} 
int min=array[0];
int max=array[0];
int result=0;
for (int index=1; index<=6;)
{
    if (array[index]>max)
    {
      max = array[index];
           }         
    index++;
}
for (int index=1; index<=6;)
{
    if (array[index]<min)
    {
      min = array[index];
           }         
    index++;
}
result=max-min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива {result}");