Console.Write("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y ");
int y = Convert.ToInt32(Console.ReadLine());
 if (x > 0 && y > 0) 
 { Console.WriteLine("Это первая четверь системы координат");};
 if (x < 0 && y > 0) 
 { Console.WriteLine("Это вторая четверь системы координат");};
 if (x < 0 && y < 0) 
 { Console.WriteLine("Это третья четверь системы координат");};    
  if (x > 0 && y < 0) 
 { Console.WriteLine("Это четвертая четверь системы координат");};    
