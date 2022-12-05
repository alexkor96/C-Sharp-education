

void Recurs(int arg1,int arg2)
// Задача 64: Задайте значения M и N. Напишите рекурсионный метод, 
//который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
{
    
    if(arg1==arg2+1) return;
    if(arg1%3==0)
    Console.Write(arg1 + " ");
    arg1++;
    Recurs(arg1,arg2);
}

Recurs(1,18);



int GetSum(int m, int n)
// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

{
    if (n > m)
        return n + GetSum(m, n - 1);
    return m;
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = GetSum(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n} равна {result}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
int AkkermanFunc(int m, int n)
{
    if(m == 0)
        {
            return n + 1;  
        }
    if(m > 0 && n == 0)
        {
            return AkkermanFunc(m - 1, 1);
        }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
		
Console.WriteLine(AkkermanFunc(2,3));