void Polindrom()
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
{
    Console.WriteLine("Данная программа отпределяет, является ли введенное Вами число полиндромом.");
    Console.WriteLine("Введите пятизначное число: ");
    int N = Convert.ToInt32(Console.ReadLine()); 
    int firstnum = N/10000;
    int secondnum = N % 10000 / 1000;
    int fournum = N%100/10;
    int fivenum = N%10;
    if(N<9999) Console.WriteLine("Число слишком короткое, попробуйте снова.");
    else if (N>100000)Console.WriteLine("Число слишком велико.");
    else if(firstnum==fivenum && secondnum == fournum) 
        {
        Console.WriteLine("Ура, Вы ввели число - полиндром.");
        }
    else Console.WriteLine("Вы ввели не полиндром.");
}

void Distance_3D()
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
{
    Console.WriteLine("Введите координаты точки А: ");
    int Ax = Convert.ToInt32(Console.ReadLine());
    int Ay = Convert.ToInt32(Console.ReadLine());
    int Az = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты точки В: ");
    int Bx = Convert.ToInt32(Console.ReadLine());
    int By = Convert.ToInt32(Console.ReadLine());
    int Bz = Convert.ToInt32(Console.ReadLine());

    double Distance = Math.Sqrt(Math.Pow(Ax-Bx,2)+Math.Pow(Ay-By,2)+Math.Pow(Az-Bz,2));
    Console.WriteLine(Math.Round(Distance,2));
}


void Cube()
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
{
    Console.WriteLine("Vvedite N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(i*i*i);
    }
}


Polindrom();
Distance_3D();
Cube();