void Zadacha54()
{
// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Random rand = new Random();
    int rows = rand.Next(3,6);
    int columns = rand.Next(3,6);
    int [,] array = new int [rows,columns];
    FillArray(array,0,9);
    PrintArray(array);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                int temp = array[i, k + 1];
                array[i, k + 1] = array[i, k];
                array[i, k] = temp;
                }
            }
        }
    }

    Console.WriteLine();

    PrintArray(array);


}
Zadacha54();

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

void Zadacha56()
{
    //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    //которая будет находить строку с наименьшей суммой элементов.
    Random rand = new Random();
        int rows = rand.Next(3,5);
        int columns = rand.Next(4,6);
        int [,] array = new int [rows,columns];
        FillArray(array,0,9);
        PrintArray(array);
        int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
            if (sumLine > tempSumLine)
            {
                sumLine = tempSumLine;
                minSumLine = i;
            }
    }

    Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


    int SumLineElements(int[,] array, int i)
    {
        int sumLine = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
            {
                sumLine += array[i,j];
            }
        return sumLine;
    }
}

Zadacha56();

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

void Zadacha58()
{
//Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
    int rows = 4;
    int columns = rows;
    int[,] array = new int[rows, columns];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
            array[i, j] = temp;
            temp++;
            if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                j++;
            else if (i < j && i + j >= array.GetLength(0) - 1)
                i++;
            else if (i >= j && i + j > array.GetLength(1) - 1)
                j--;
            else
                i--;
    }

    PrintArray(array);

}

Zadacha58();

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
