// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Массив с случайными трехзначными числами : ");
int[] numbers = new int[20];
Random random = new Random();
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100, 999);

    Console.Write(numbers[i] + " ");

    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"\nКоличество четных чисел в массиве: {count}");
Console.WriteLine();
