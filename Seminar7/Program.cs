//Теория по семинару 7
/*

*/
//Используемые функции
/*
int[] FillingScale()
{
    Console.Write("Задайте размер вашего массива: ");
    int [] scale = new int[2];
    scale[0] = Convert.ToInt32(Console.ReadLine());
    scale[1] = Convert.ToInt32(Console.ReadLine());
    return scale;
}
int FillingState()
{
    Console.Write("Введите 1, чтобы ввести массив самостоятельно или введите 0, чтобы заполнить массив случайными числами: ");
    int state = Convert.ToInt32(Console.ReadLine());
    return state;
}
double [,] FillingArrayDouble(int[] scale, int state)
{
    double [,] array = new double [scale[0], scale[1]];
    if(state == 1)
    {
        Console.Write("Введите массив: ");
        for(int i = 0; i < scale[0]; i++)
            for(int j = 0; j < scale[1]; j++)
            {
                array[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        return array;
    }
    else
    {
        Console.Write("Введите нижний и верхний предел случайных чисел: ");
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < scale[0]; i++)
            for(int j = 0; j < scale[1]; j++)
            {
                array[i, j] = new Random().Next(min, max + 1);
            }
        return array;
    }
}
int [,] FillingArrayInt(int[] scale, int state)
{
    int [,] array = new int [scale[0], scale[1]];
    if(state == 1)
    {
        Console.Write("Введите массив: ");
        for(int i = 0; i < scale[0]; i++)
            for(int j = 0; j < scale[1]; j++)
            {
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        return array;
    }
    else
    {
        Console.Write("Введите нижний и верхний предел случайных чисел: ");
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < scale[0]; i++)
            for(int j = 0; j < scale[1]; j++)
            {
                array[i, j] = new Random().Next(min, max + 1);
            }
        return array;
    }
}
void ShowArrayDouble(int[] scale, double[,] array)
{
    Console.WriteLine($"Полученный массив размером {scale[0]} на {scale[1]}: ");
    for(int i = 0; i < scale[0]; i++)
    {
        Console.Write(array[i, 0]);
        for(int j = 1; j < scale[1]; j++)
        {
            Console.Write(", " + array[i, j]);
        }
        Console.WriteLine(" ");
    }
}
void ShowArrayInt(int[] scale, int[,] array)
{
    Console.WriteLine($"Полученный массив размером {scale[0]} на {scale[1]}: ");
    for(int i = 0; i < scale[0]; i++)
    {
        Console.Write(array[i, 0]);
        for(int j = 1; j < scale[1]; j++)
        {
            Console.Write(", " + array[i, j]);
        }
        Console.WriteLine(" ");
    }
}
void ColumnAverage(int[] scale, int[,] array)
{
    int[] average = new int[scale[1]];
    Console.WriteLine("Полученный массив средних арифметических всех столбцов в заданном двумерном массиве: ");
    int mar = 0;
    for(int j = 0; j < scale[1]; j++)
    {
        for(int i = 0; i < scale[0]; i++)
        {
            mar = mar + array[i, j];
        }
        average[j] = mar / scale[0];
        mar = 0;
    }
    Console.Write("[" + average[0]);
    for(int i = 1; i < scale[0]; i++)
    {
        Console.Write(", " + average[i]);
    }
    Console.WriteLine("]");
}
*/
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
int[] scale = FillingScale();
int state = FillingState();
double[,] array = new double[scale[0], scale[1]];
array = FillingArrayDouble(scale, state);
ShowArrayDouble(scale, array);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[] scale = FillingScale();
int state = FillingState();
double[,] array = FillingArrayDouble(scale, state);
ShowArrayDouble(scale, array);

Console.Write("Введите позицию интересующего вас элемента: ");
int [] poz = new int[2];
poz[0] = Convert.ToInt32(Console.ReadLine());
poz[1] = Convert.ToInt32(Console.ReadLine());

if(poz[0] > 0 && poz[0] <= scale[0] && poz[1] > 0 && poz[1] <= scale[1])
    Console.WriteLine($"Значение элемента с позицией {poz[0]}, {poz[1]} равно {array[(poz[0] - 1), (poz[1] - 1)]}");
else 
    Console.WriteLine("Элемента с заданной позицией не существует");
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[] scale = FillingScale();
int state = FillingState();
int[,] array = FillingArrayInt(scale, state);
ShowArrayInt(scale, array);

ColumnAverage(scale, array);
*/
//Реализация выбора желаемой задачи
/*

*/