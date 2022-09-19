Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if(a > b)
{
    Console.WriteLine("Число a - большее");
    Console.WriteLine("Число b - меньшее");
}
else if(a < b)
{
    Console.WriteLine("Число b - большее");
    Console.WriteLine("Число a - меньшее");
}