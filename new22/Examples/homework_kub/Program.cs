Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
double result=0;
for (int index = 1; index<=num;)
{
result=Math.Pow(index,3);
  Console.Write($"{result}, ");
index++;
} 
 