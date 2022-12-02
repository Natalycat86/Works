Console.WriteLine("Введите элементы массива");
string s = Convert.ToString(Console.ReadLine());
string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);
int[] n = nums.Select(Int32.Parse).ToArray();
int result=0;
for (int index=0; index<=n.Length-1;index++)
{
    if (n[index]>0)
    {
      result=result+1;
           }         
   }
Console.WriteLine();
Console.WriteLine($"Количество чисел больше нуля - {result}");  