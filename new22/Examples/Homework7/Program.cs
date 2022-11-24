int[] array = {1, 2, 3, 4, 5};
Console.WriteLine("Введите число соответствующее дню недели от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
var hash = new HashSet<int>(array);
if (hash.Contains(num)) Console.WriteLine("Нет");
else Console.WriteLine("да"); 