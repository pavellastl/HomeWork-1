// Задача № 7 последняя цифра трехзначного числа
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine());
int i = N % 10;
Console.WriteLine($"{i}");
