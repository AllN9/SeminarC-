//Теория по семинару 8
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
int[] FillingFScale()
{
    Console.Write("Задайте размер вашего первого массива: ");
    int [] scale = new int[2];
    scale[0] = Convert.ToInt32(Console.ReadLine());
    scale[1] = Convert.ToInt32(Console.ReadLine());
    return scale;
}
int[] FillingSScale()
{
    Console.Write("Задайте размер вашего второго массива: ");
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
void ShowResArrayInt(int[] scale, int[,] array)
{
    Console.WriteLine($"Полученный массив после умножения размером {scale[0]} на {scale[1]}: ");
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
void Descending(int[] scale, int[,] array)
{
    int mar;
    for(int i = 0; i < scale[0]; i++)
    {
        int j = 1;
        while(j < scale[1])
        {
            if(array[i, j - 1] < array[i, j])
            {
                mar = array[i, j];
                array[i, j] = array[i, j - 1];
                array[i, j - 1] = mar;
                j = 1;
            }
            else j++;
        }
    }
    Console.WriteLine($"Полученный массив после преобразования размером {scale[0]} на {scale[1]}: ");
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
int[] MinInArray(int[] scale, int[,] array)
{
    int[] narray = new int[scale[0]];
    for (int i = 0; i < scale[0]; i++)
    {
        int mar = 0;
        for(int j = 0; j < scale[1]; j++)
        {
            mar = mar + array[i, j];
        }
        narray[i] = mar;
    }
    return narray;
}
*/
//Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[] scale = FillingScale();
int state = FillingState();
int[,] array = FillingArrayInt(scale, state);
ShowArrayInt(scale, array);

Descending(scale, array);
*/
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[] scale = FillingScale();
int state = FillingState();
int[,] array = FillingArrayInt(scale, state);
ShowArrayInt(scale, array);

int[] narray =  MinInArray(scale, array);

int min = narray[0];
int iMin = 0;
for(int i = 1; i < scale[0]; i++)
{
    if(min > narray[i])
    {
        min = narray[i];
        iMin = i;
    }
}
Console.WriteLine($"В заданном массиве строка с наименьшей суммой эдементов под номером {iMin + 1}");
Console.Write("Полученная строка: ");
Console.Write(array[iMin, 0]);
for(int j = 1; j < scale[1]; j++)
{
    Console.Write(", " + array[iMin, j]);
}
Console.WriteLine(" ");
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[] fscale = FillingFScale();
int fstate = FillingState();
int[,] farray = FillingArrayInt(fscale, fstate);
ShowArrayInt(fscale, farray);

int[] sscale = FillingScale();
int sstate = FillingState();
int[,] sarray = FillingArrayInt(sscale, sstate);
ShowArrayInt(sscale, sarray);

int max = 0;
if(fscale[0] < sscale[0])
    max = sscale[0];
else max = fscale[0];
int[] nscale = {max, max};
int[,] narray = new int[max, max];
for(int i = 0; i < max; i++)
{
    for(int j = 0; j < max; j++)
    {
        int sum = 0;
        for(int k = 0; k < max; k++)
        {
            sum = sum + (farray[i, k] * sarray[k, j]);
        }
        narray[i, j] = sum;
    }
}

ShowResArrayInt(nscale, narray);
*/
//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int l = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[n, m, l];

for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        for(int k = 0; k < l; k++)
        {
            array[i, j, k] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

Console.WriteLine("Полученный массив: ");
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < m; j++)
    {
        Console.Write($"[{array[i, j, 0]}({i}, {j}, 0)");
        for(int k = 1; k < l; k++)
        {
            Console.Write($", {array[i, j, k]}({i}, {j}, {k})");
        }
        Console.WriteLine("]");
    }
}
*/
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int[,] array = new int[4, 4];
int[] scale = {4, 4};

int iBeg = 0, iFin = 0, jBeg = 0, jFin = 0;
int k = 1, i = 0, j = 0;

while(k <= 16)
{
    array[i, j] = k;
    if(i == iBeg && j < 4 - jFin - 1)
        j++;
    else if(j == 4 - iFin - 1 && i < 4 -iFin - 1)
        i++;
    else if(i == 4 - iFin - 1 && j > jBeg)
        j--;
    else
        i --;
    
    if((i == iBeg + 1) && (j == jBeg) && (jBeg != 4 - jFin - 1))
    {
        iBeg++; 
        iFin++; 
        jBeg++;
        jFin++;
    }
    k++;
}

ShowArrayInt(scale, array);
*/
//Реализация выбора желаемой задачи
/*

*/