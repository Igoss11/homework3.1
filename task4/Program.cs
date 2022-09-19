Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());
if(a > b)
{
    if(a > c)
    {
        Console.WriteLine("Число a - max");
    }
    else if(a < c)
    {
        Console.WriteLine("Число c - max");
    }
}
else
{
    if(b > c)
    {
        Console.WriteLine("Число b - max");
    }
    else if(b < c)
    {
        Console.WriteLine("Число c - max");
    }
}