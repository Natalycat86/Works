Console.WriteLine("Введите имя Ваше:");
string username = Console.ReadLine();

if(username.ToLower() == "миша")
{
 Console.WriteLine("Здравствуй, Миша, мой любимый!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}