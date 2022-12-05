void SecondNumb()
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
{
    Console.WriteLine("Введите трехзначное число: ");
    int n = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Вы ввели: "+n);
    if (n<100) Console.WriteLine("третьей цифры нет");
    else if(n>999)
        {
            Console.WriteLine("Вы ввели не трехзначное число:)");
        }
    else 
        {
            int secondnum = n % 100 / 10;
            Console.WriteLine("Вторая цифра введенного числа: " + secondnum);
        }
}

void ThirdNumb()
//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
{
    Console.WriteLine("Программа показывает третью цифру в веденном Вами числе.");
    Console.WriteLine();
    Console.WriteLine("Введите трехзначное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вы ввели: "+n);
    if (n<100) Console.WriteLine("третьей цифры нет");
    else if(n>999)
        {
            Console.WriteLine("Вы ввели не трехзначное число:)");
        }
    else 
        {
            int thirdnum = n%10;
            Console.WriteLine("Третья цифра введенного числа: " + thirdnum);
        }
}

void WeekDay()
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

{
    Console.WriteLine("Данная программа показывает день недели по введенной цифре.");
    Console.WriteLine();
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 7) Console.WriteLine("день недели не отпределен, попробуйте снова.");
    switch (num)
    {
        case  1:
        Console.WriteLine("Пн - Не выходной");
        break;
        case 2:
        Console.WriteLine("Вт - Не выходной");
        break;
        case 3:
        Console.WriteLine("Ср - Не выходной");
        break;
        case 4:
        Console.WriteLine("Чт - Не выходной");
        break;
        case 5:
        Console.WriteLine("Пт - Не выходной");
        break;
        case 6:
        Console.WriteLine("Сб - Выходной");
        break;
        case 7:
        Console.WriteLine("Вс - Выходной");
        break;
    }
}


ThirdNumb();
SecondNumb();
WeekDay();   


