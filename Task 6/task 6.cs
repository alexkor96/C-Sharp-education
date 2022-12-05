// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha41 ()
{
    Console.WriteLine("Сколько чисел хотите ввести:  ");
    int M = Convert.ToInt32(Console.ReadLine());
   int [] array = new int [M];
   int count = 0;

    Console.WriteLine("введите числа:  ");

   for (int i = 0; i < M; i++)
   {
       array[i]= Convert.ToInt32(Console.ReadLine()); 
       if(array[i]> 0) count ++;
    
   }
        Console.WriteLine();
        Console.WriteLine($"Пользователь ввел {count} положительных чисел");
}

Zadacha41();
void Zadacha43()
{
    //Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    //значения b1, k1, b2 и k2 задаются пользователем.
    Console.WriteLine("Введите значение b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    if(k1==k2) Console.WriteLine("Прямые параллельны");
    else 
    {
        double x= (b2 - b1) / (k1 - k2);
        double y  = k2 * x + b2;
        Console.WriteLine($"Точка пересечения двух прямых ({Math.Round(x,2)} ; {Math.Round(y,2)})");
    }

}
Zadacha43();
