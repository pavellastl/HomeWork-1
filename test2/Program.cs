// задача №8 четные числа от 1 до N
Console.Clear();
Console.WriteLine("Введите положительное число N и вам выведется все целые сисла от 1 до N ");
int N = int.Parse(Console.ReadLine());
if(N <= 1)
{
    Console.WriteLine("Неправильное число");
}


for(int i = 2; i <= N; i = i + 2)
{
Console.WriteLine($"{i}");
}