Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int result=0;
int index=0;
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}
while (index< str.Length)
{
result=result+b[index];
index=index+1;
}
Console.WriteLine($"{result}"); 