//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите число");
int day1 = Convert.ToInt32(Console.ReadLine());
if (day1 == 1)
{
    Console.Write("О боже, Понедельник");
}
else if (day1 == 2) 
{
  Console.Write("Вторник"); 
}
else if (day1 == 3)
{
  Console.Write("Среда"); 
}
else if (day1 == 4)
{
  Console.Write("Четверг"); 
}
else if (day1 == 5)
{
  Console.Write("Наконец-то пятница"); 
}
else if (day1 == 6)
{
  Console.Write("Суббота, СПААААТЬ"); 
}
else if (day1 == 7)
{
  Console.Write("Лучший день недели"); 
}