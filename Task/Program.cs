/*Задача 34: Задайте массив заполненный случайными
 положительными трёхзначными числами. 
 Напишите программу, которая покажет количество чётных чисел в массиве.*/
/*void FillArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
        array[i] = new Random().Next(100,1000);

}

void PrintArray(int [] array)
{
    foreach(int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}
void Summ(int [] array)
{
    int sum1 = 0;
    foreach(int item in array)
        if(item%2==0)
            sum1++;
    Console.Write($"Колличество четных чисел {sum1}");

}

int [] array = new int [10];
FillArray(array);
PrintArray(array);
Summ(array);*/

/*Задача 36: Задайте одномерный массив, заполненный
 случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

/*void FillArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
        array[i] = new Random().Next(1,100);

}

void PrintArray(int [] array)
{
    foreach(int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}
void Summ(int [] array)
{
    int sum1 = 0;
    for(int i=1;i<array.Length;i+=2)
        sum1 += array[i];
    Console.Write($"Cумма элементов, стоящих на нечётных позициях {sum1}");

}

int [] array = new int [10];
FillArray(array);
PrintArray(array);
Summ(array);*/

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

void FillArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
        array[i] = new Random().Next(100,1000);

}

void PrintArray(int [] array)
{
    foreach(int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}
void Diff(int [] array)
{
    int min = array[0];
    int max = array[0];
    int diff1 = 0;
    for(int i = 0;i<array.Length;i++)
        if(max<array[i])
            max = array[i];
    for(int i = 0;i<array.Length;i++)
        if(min>array[i])
            min = array[i];
    diff1 = max - min;
Console.Write($"Разница между максимальным и минимальным элементов массива равна {diff1}");

}

int [] array = new int [10];
FillArray(array);
PrintArray(array);
Diff(array);

