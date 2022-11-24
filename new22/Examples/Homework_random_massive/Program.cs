int[] array = new int[8];
for (int i=0; i < array.Length; i++)
{
    array[i]= new Random().Next(-2147483647,2147483647);
    Console.Write($"{array[i]}, ");
} 

