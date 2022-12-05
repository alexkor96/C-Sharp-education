void Zadacha47()
{

    //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


    Random rand = new Random();
    int rows = rand.Next(4,4);
    int columns = rand.Next(4,4);
    double [,] array = new double [rows,columns];
    FillDoubArray(array);
    PrintDoubArray(array);

    void FillDoubArray(double [,] array, int StartNums = 0, int FinishNums = 9)
    {
        Random rand = new Random();
        FinishNums++; 
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i,j] = rand.NextDouble() *5;
                }
            }
    }

    void PrintDoubArray(double [,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(Math.Round(array[i,j],1) + "\t");
                }
                Console.WriteLine();
            }

    }
}

Zadacha47();
void Zadacha50()
{    
    //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    //и возвращает значение этого элемента или же указание, что такого элемента нет.
       
    Random rand = new Random();
    int rows = rand.Next(4,4);
    int columns = rand.Next(3,4);
    int [,] array = new int [rows,columns];
    FillArray(array,1,10);
    PrintArray(array);
    FindNum(array);

    
    



}
void FindNum(int[,] array)
{    
    Console.WriteLine("введите индекс строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите индекс столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int find = 0;
   // bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                if (m ==i+1 && n == j+1)   find =   array[i,j];
                if (m >i +1 && n > j)Console.WriteLine("Такого элемента нет");
        }
                

    }
        Console.WriteLine($"Число {find} есть в массиве");
        

}
void FillArray(int [,] array, int StartNums = 0, int FinishNums = 9)
{
    Random rand = new Random();
    FinishNums++; 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i,j] = rand.Next(StartNums,FinishNums);
            }
        }
}
void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                 Console.Write(array[i,j] + "\t");
            }
             Console.WriteLine();
        }

}


Zadacha50();

void Zadacha52()
{
    //Задача 52. Задайте двумерный массив из целых чисел. 
    //Найдите среднее арифметическое элементов в каждом столбце.
    Random rand = new Random();
    int rows = rand.Next(4,4);
    int columns = rand.Next(3,4);
    int [,] array = new int [rows,columns];
    FillArray(array,1,10);
    PrintArray(array);
    double sum = 0;
    double avg = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {   
            sum+=array[i,j];
            avg=sum/array.GetLength(0);
         
        }   sum*=0;
            Console.WriteLine($"Среднее арифметическое в столбцах равно " + Math.Round(avg,2));

    }


}
void FillArray(int [,] array, int StartNums = 0, int FinishNums = 9)
{
    Random rand = new Random();
    FinishNums++; 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i,j] = rand.Next(StartNums,FinishNums);
            }
        }
}
void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                 Console.Write(array[i,j] + "\t");
            }
             Console.WriteLine();
        }

}

Zadacha52();