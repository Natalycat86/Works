Console.WriteLine("Задайте значение");
int num = Convert.ToInt32(Console.ReadLine());
void Recur(int num)
{
    if(num == 1);
    {
       Console.WriteLine($"{num}"); 
    }
    else
    {
    Recur(num - 1);  
     }
    Console.WriteLine($"{num}");
}
int x = Recur(num);