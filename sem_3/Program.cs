
Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  третее число");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите четвертое число");
int num4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1}-{num2}-{num3}-{num4}");


int RedInt()
{
    System.Console.WriteLine("введите число");
    int temp = Convert.ToInt32(Console.ReardLine());
    return temp;
}