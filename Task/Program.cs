/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

/*void FillArray(double[,] array)

{
    Random rand = new Random();
    for (int i =0; i<array.GetLength(0);i++)
        for (int j =0; j<array.GetLength(1);j++)
            
            array[i,j] = rand.Next(-100, 100) + rand.NextDouble();
            

}

void PrintArray(double[,] array)
{
    for (int i =0; i<array.GetLength(0);i++)
        {
        for (int j =0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t") ;
        Console.WriteLine();
        }       
}



Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [rows,cols];
FillArray(array);
PrintArray(array);*/

/*Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого
 элемента или же указание, что такого элемента нет.*/

 /*void FillArray(int[,] array)

{
    
    for (int i =0; i<array.GetLength(0);i++)
        for (int j =0; j<array.GetLength(1);j++)
            
            array[i,j] = new Random().Next(0,10);
            

}

void PrintArray(int[,] array)
{
    for (int i =0; i<array.GetLength(0);i++)
        {
        for (int j =0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t") ;
        Console.WriteLine();
        }       
}
void FindPosition(int[,] array,int number )
{
    for(int i = 0;i<array.GetLength(0); i++)
        for(int j = 0;j<array.GetLength(0); j++)
    if(array[i,j] == number)
        Console.WriteLine($"{i},{j}");
           
  

}

 Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [rows,cols];
FillArray(array);
PrintArray(array);
FindPosition(array,number);
*/