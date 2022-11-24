int Summa(int a)
{
    int index=0;
    int summ=0;
    while (a >= index)
    summ = summ + index; 
    index++; 
    return summ;    
}

Console.Write("Введите А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa);



// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36