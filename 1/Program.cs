// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная


while (true) 
{
    Console.Write("Введите любое число, или символ 'Q' для выхода из программы  ");
    string input = Console.ReadLine();
    if (input == "q") 
    {
        Console.WriteLine(" Вы Вели 'q' Программа завершена!!!");
        break;
    }
    if (input == "Q")
    {
       Console.WriteLine(" Вы Вели 'Q' Программа завершена!!!");
        break;
    }
    
    int number;

    int sum = 0;

    if (int.TryParse(input, out number))



        while (number > 0) 
        {
            sum += number % 10; 
            number /= 10;
        }
    if (sum % 2 == 0) 
    {
        Console.WriteLine("сумма цифр четная");
        System.Console.WriteLine();
        break;
    }

    else
    {
        Console.WriteLine("Некорректный ввод!!!!. Пожалуйста, введите целое число или символ 'q'.");
        System.Console.WriteLine();
    }

}

