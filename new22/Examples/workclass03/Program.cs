Console.Write("Введите x точки А");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y точки А ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x точки B");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y точки B ");
double y2 = Convert.ToDouble(Console.ReadLine());
double num1 = Math.Pow((x2 - x1), 2);
double num2 = Math.Pow((y2 - y1), 2);
double num3 = num1 + num2;
double result = Math.Sqrt(num3);
Console.WriteLine($"Расстояние равно {result}"); 