//Теория по семинару 4
/*

*/
//Используемые функции
/*
int Greeting()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
int [] FillingArray(int size)
{
    int [] array = new int [size];
    Console.Write("Задайте нижний и верхний предел, в котором будут выбираться случайные числа: ");
    int min = Convert.ToInt32(Console.ReadLine());
    int max = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    Console.Write("Полученный массив: [" + array[0]);
    for(int i = 1; i < size; i++)
    {
        Console.Write(", " + array[i]);
    }
    Console.WriteLine("]");
    return array;
}
*/
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int size = Greeting();
int [] array = FillingArray(size);

int res = 0;
for(int i = 0; i < size; i++)
{
    if(array[i] % 2 == 0)
        res ++;
}

Console.WriteLine("Количество четных чисел равно " + res);
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int size = Greeting();
int [] array = FillingArray(size);

int res = 0;
for(int i = 0; i < size; i += 2)
{
    res = res + array[i];
}

Console.WriteLine("Сумма чисел, стоящих на нечетных элементах равно " + res);
*/
//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
/*
double [] FillingArrayDouble(int size)
{
    Console.Write("Введите массив: ");
    double [] array = new double [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.Write("Полученный массив: [" + array[0]);
    for(int i = 1; i < size; i++)
    {
        Console.Write(", " + array[i]);
    }
    Console.WriteLine("]");
    return array;
}

int size = Greeting();
double [] array = FillingArrayDouble(size);

double min = array[0], max = array[0];
for(int i = 1; i < size; i++)
{
    if(min > array[i])
        min = array[i];
    else
        if(max < array[i])
            max = array[i];
}

Console.WriteLine($"Максимальное и минимальное число в массиве это: {min} {max}");
*/