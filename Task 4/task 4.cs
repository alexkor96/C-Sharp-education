void Degree()
//Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

   {
        Console.WriteLine("Введите число: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int Degree=1;
            for (int i = 1; i <= N; i++)
                {
                    Degree *=  A;
                }
        Console.WriteLine("{0} ^ {1} = {2}", A, N, Degree);
   }

void SumDig()
{
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Console.WriteLine("Введите число: ");
    int Number= Convert.ToInt32(Console.ReadLine());
    int sum =0;
    while(Number>0)
        {
            sum+=Number%10;
            Number/=10;
        }
    Console.WriteLine($"Сумма цифр в числе = " + sum);
}

int [] BubbleSort(int[] mas)
//Напишите программу, которая задаёт массив из 8 случайных целых чисел
//и выводит отсортированный по модулю массив
{
    int temp;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (Math.Abs(mas[i]) > Math.Abs(mas[j]))
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }                   
        }            
    }
    return mas;
}

int[] mas = new int [8];

Console.WriteLine("Сгенерированный Массив: ");
    for (int i = 0; i < mas.Length; i++)
        {
            int N = new Random().Next(-10, 11);
            mas[i]= N;
            Console.Write(mas[i] + " ");
        }
    Console.WriteLine();

Console.WriteLine("Отсортированный по модулю массив: ");
    BubbleSort(mas); 
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }
    

Degree();
SumDig();
