Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int a = num/10;
int b = num%10;
int c = a*10;
int d = b*10;
int e = c-5;
double f = d+Math.Pow(b,3);
int a1 = e%10;
double g =e*f-a1;
double b1 = f%10;
double h =f*e-b1;
double i =g+h;
Console.WriteLine($"{i}");

