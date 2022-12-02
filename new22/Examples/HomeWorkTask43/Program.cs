Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2)
{
    Console.WriteLine("Прямые паралельны");
}
else{
    double x = ((b2 - b1) / (k1 - k2));
    double y=k1*(b2-b1)/(k1-k2)+b1;
    Console.WriteLine($"({x}; {y})"); 
   } 