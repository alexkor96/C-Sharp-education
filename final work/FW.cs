//Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых <=3 символам

//      Введите элементы массива:    0   ,  1 ,  2, ,    3   ,  4   ;
string[] array = new string [5] {"Moscow","11","tex", "Hello", ":)"};
string[] arrayThree = new string[array.Length];
  int count=0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=3)
    {
        arrayThree[count] = array[i];
        count++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arrayThree);
