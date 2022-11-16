Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;
int num2 = num;
while (num2 >= 1)
{num2 = num2/10;
index = index + 1;}
int del_a = 1;
int index_a = 0;
while (index_a < index-3)
{del_a =del_a*10;
index_a=index_a+1;}
int a = num / del_a;
int del_b = 1;
int index_b = 0;
while (index_b < index-2)
{del_b =del_b*10;
index_b=index_b+1;}
int b = num /del_b*10;
int c = a - b;
Console.Write($"{c}");
