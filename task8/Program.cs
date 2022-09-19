Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int a = 1;
bool not = true;
Console.WriteLine("Четные числа от 1 до " + number + ":");
while (a <= number)
{
    if (a % 2 != 1)
        {
            Console.Write(a + "   ");
            not = false;
        }
    a++;
}
if (not)
    {
        Console.WriteLine("Нет четных чисел");
    }