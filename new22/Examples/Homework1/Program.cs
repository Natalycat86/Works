Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
    Console.WriteLine("Числа равны");
}
else if (num1 > num2)
   {
    Console.WriteLine($"Большее число {num1}, а меньшее число {num2}");
   }
   else
   {
    Console.WriteLine($"Большее число {num2}, а меньшее число {num1}");
   }