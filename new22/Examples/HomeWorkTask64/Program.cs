int a = InputInt("Введите положительное число ");
int b = 1;
if (a < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(a, b));

int NaturalNumber(int a, int b)
{
    if (a == b)
        return a;
    else
        Console.Write($"{NaturalNumber(a, b + 1)}, ");
    return b;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}