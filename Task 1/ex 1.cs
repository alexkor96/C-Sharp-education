void task1 (){
    //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    Console.WriteLine("Введите 1 число: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 число: ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    int Max = 0;
    if(n1 < n2){
        Max = n2;
        Console.WriteLine("Max = " + Max);
    }
    else if (n1 > n2) 
    {
        Max = n1;
        Console.WriteLine("Max = " + Max);
    }
    else Console.WriteLine("Числа равны");
}


void task2(){
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

    Console.WriteLine("Введите 1 число: ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2 число: ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 3 число: ");
    int n3 = Convert.ToInt32(Console.ReadLine());
    int Max = 0;
    if(n1 < n2) Max = n2;
    else Max = n1;
    if(Max < n3) Max = n3;
    Console.WriteLine("Max = " + Max);
}


    void task3 (){
        // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
    Console.WriteLine("Введите число: ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    if (n1 % 2 == 0)
    {
    Console.Write( n1 + " Число четное");
    } 
    else Console.Write(n1 + "Число не четное");
}


void task4(){
    // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

    Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine ());
    int start = 1;
    while (start <= n )
    {
        if (start%2 == 0)
        {
            Console.Write(start + " ");
        }

        start++;     
    } 

}

task1 ();
task2 ();
task3 ();
task4 ();
