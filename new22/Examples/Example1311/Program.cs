Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (max < num2)
{
    num1 = max;
}
else if (max<num3)
{
    num2 = max;
}
else if (max < num3);
    {num3 = max;}
 
Console.WriteLine($"Максимальное число {max}"); 
 