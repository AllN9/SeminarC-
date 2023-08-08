//Теория по семинару 5
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
Console.WriteLine($"Разница между ними равно: {max - min}");
*/
//Реализация выбора желаемой задачи
/*
int Greeting()
{
    Console.Write("Enter the number of the desired task or enter 0 to finish the program: ");
    int numberOfTask = Convert.ToInt32(Console.ReadLine());
    while(numberOfTask != 34 && numberOfTask != 36 && numberOfTask != 38 && numberOfTask != 0)
    {
        Console.WriteLine("There is no task with this number\nTask list: 34, 36, 38");
        Console.Write("Enter the correct number of the desired task or enter 0 to finish the program: ");
        numberOfTask = Convert.ToInt32(Console.ReadLine());
    }
    return numberOfTask;
}
int RequestSize()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}
double [] FillingArray(int size)
{
    double [] array = new double [size];
    Console.Write("Задайте нижний и верхний предел, в котором будут выбираться случайные числа: ");
    int min = Convert.ToInt32(Console.ReadLine());
    int max = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
double [] FillingArrayDouble(int size)
{
    Console.Write("Введите массив: ");
    double [] array = new double [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}
void OutputMas(double [] array, int size)
{
    Console.Write("Полученный массив: [" + array[0]);
    for(int i = 1; i < size; i++)
    {
        Console.Write(", " + array[i]);
    }
    Console.WriteLine("]");
}
void SearchMar(double [] array, int size)
{
    double min = array[0], max = array[0];
    for(int i = 1; i < size; i++)
    {
        if(min > array[i])
            min = array[i];
        else
            if(max < array[i])
                max = array[i];
    }
    Console.WriteLine($"Максимальное и минимальное число в массиве это: {min}, {max}");
    Console.WriteLine($"Разница между ними равно: {max - min}");
}
void QuantitySearchEven(double [] array, int size)
{
    double res = 0;
    for(int i = 0; i < size; i++)
    {
        if(array[i] % 2 == 0)
            res ++;
    }
    Console.WriteLine("Количество четных чисел равно " + res);
}
void SearchSumNEvenEl(double [] array, int size)
{
    double res = 0;
    for(int i = 0; i < size; i += 2)
    {
        res = res + array[i];
    }
    Console.WriteLine("Сумма чисел, стоящих на нечетных элементах равно " + res);
}

Console.WriteLine("Hello!");
int numberOfTask = Greeting();

while(numberOfTask != 0)
{
    int size = RequestSize();
    if(numberOfTask == 38)
    {
        double [] array = FillingArrayDouble(size);
        OutputMas(array, size);
        SearchMar(array, size);
    }
    else
    {
        double [] array = FillingArray(size);
        if(numberOfTask == 34)
        {
            OutputMas(array, size);
            QuantitySearchEven(array, size);
        }
        else
        {
            OutputMas(array, size);
            SearchSumNEvenEl(array, size);
        }
    }
    numberOfTask = Greeting();
}

Console.WriteLine("Bye-Bye!");
*/