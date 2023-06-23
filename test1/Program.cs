// Задача №4 максимальное из 3-х чисел
Console.Clear();
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if(b > max)
{
    max = b;
}
if(c > max)

{
    max = c;
}
Console.WriteLine($"{max}");