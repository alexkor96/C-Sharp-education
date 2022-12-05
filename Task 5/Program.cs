void Zadacha34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.

    int [] array = new int [10];
    FillArray(array, 100, 998);
    PrintArray(array);
    FindEven(array);
}



void FillArray(int [] array, int StartNum = -10, int FinishNum = 10)
{
    FinishNum++;
    Random random = new Random();
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(StartNum,FinishNum);

            }
}
void PrintArray(int [] array)
{   
         for (int i = 0;i < array.Length; i++)
            {
                    Console.Write(array[i] + "  ");
            }
        Console.WriteLine();
}
void FindEven(int [] array)
{
    int count = 0;
        for (int i = 0; i < array.Length; i++)
            {   
                if(array[i]%2 == 0)
                count ++;
            }
    Console.WriteLine("Колличество четных числе в массиве = " + count);
}


void Zadacha36()
{
   //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
   //Найдите сумму элементов, стоящих на нечётных позициях.
   int [] array = new int [10];
   FillArray(array, 10, 98);
   PrintArray(array);
   Odd(array);
}



void FillArray(int [] array, int StartNum = -10, int FinishNum = 10)
{
    FinishNum++;
    Random random = new Random();
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(StartNum,FinishNum);

            }
}
void PrintArray(int [] array)
{   
         for (int i = 0;i < array.Length; i++)
            {
                    Console.Write(array[i] + "  ");
            }
        Console.WriteLine();
}
void Odd(int [] array)
{
    int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if(i%2 == 0) count += array[i];
            }
    Console.WriteLine("сумма элементов, стоящих на нечётных позициях = " + count);
}


Zadacha36();
//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

 double [] array = new double[7];

    FillDoubArray(array);
    PrintDoubArray(array);    
    MaxMin(array);
        
        
void MaxMin(double[] array)
{
    double max = array[0];
    double min = max;
    double result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
        if(array[i]<min) min= array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Максимальный Элемент = |{Math.Round(max,1)}| ; минимальный элемент = |{Math.Round(min,1)}|");
    
    
    Console.WriteLine("найдем разницу между Max и Min");
        result = Math.Round(max,1) - Math.Round(min,1);
        Console.WriteLine($"Разница  |{Math.Round(max,1)}| и |{Math.Round(min,1)}| = " + Math.Round(result,1));

}
void FillDoubArray(double[] array)
{
     double min = Math.Round(array[0],1);
 double max = Math.Round(array[0],1);
 
 Random random = new Random();
        for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 20;
                
            }
}
void PrintDoubArray(double[] array)
{
    Console.WriteLine("Выведем полученный массив: ");
        for (int i = 1; i < array.Length; i++)
        {
             Console.Write($"|{Math.Round(array[i],1)}|" + "  ");
        }
}
