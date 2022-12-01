Console.WriteLine("Введите желаемое кол-во элементов массива");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
for (int i=0; i < array.Length; i++)
{
    array[i]= new Random().Next(100,1000);
    Console.Write($"{array[i]}, ");
} 
int result=0;
for (int index=0; index<=array.Length-1;)
{
    if (array[index] % 2==0)
    {
    result = result+1; 
    index++;
        }
     else 
     {
        index++;
     }
}
Console.WriteLine();
Console.WriteLine($"Кол-во четных чисел {result}");