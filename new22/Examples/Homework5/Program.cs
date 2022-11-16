Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int a = num/10;
int b = num /100;
int c = b * 10;
int d = a - c;
Console.Write($"{d}");