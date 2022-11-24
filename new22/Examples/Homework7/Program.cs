<<<<<<< HEAD
﻿int[] array = {1, 2, 3, 4, 5};
=======
int[] array = {1, 2, 3, 4, 5};
>>>>>>> 97e73988d3412e9cff12eddb358490fc0bc48c8e
Console.WriteLine("Введите число соответствующее дню недели от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
var hash = new HashSet<int>(array);
if (hash.Contains(num)) Console.WriteLine("Нет");
<<<<<<< HEAD
else Console.WriteLine("да"); 
=======
else Console.WriteLine("да"); 
>>>>>>> 97e73988d3412e9cff12eddb358490fc0bc48c8e
