/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
/*void FillArray (int [] array)
{
    for(int i=0; i<array.Length; i++)
        array[i] = new Random().Next(-9,10);

}

void PrintArray(int [] array)
{
    foreach(int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}
void ColNumber(int [] array)
{
    int i = 0;
    foreach(int item in array)
        if(item>0)
            i++;
    Console.WriteLine($"Чисел больше 0 пользователь ввёл {i}");


}
Console.WriteLine($"Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
FillArray(array);
PrintArray(array);
ColNumber(array);*/


/*Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.*/

void PrintArray(double [] array)
{
    foreach(int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}
double[] Fibon(int count)
{
    double[] res = new double[count];
    res[0] = 0;
    res[1] = 1;
    for (int i = 2; i < res.Length; i++)
    {
        res[i] = res[i - 2] + res[i - 1];
    }
    return res;
}

 Console.WriteLine("Введите номер числа фиббоначи: ");
 PrintArray(Fibon(Convert.ToInt32(Console.ReadLine())));