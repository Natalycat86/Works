Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int c = Convert.ToInt32(Console.ReadLine());
int max = c;
 if (a >= b && a >= c) 
 { max = a; }
            else
            {
                if (b >= a && b >= c)
                 { max = b; }
                else
                {
                    if (c >= b && c >= a)
                     { max = c; }
                };}
Console.WriteLine($"Максимальное число {max}"); 