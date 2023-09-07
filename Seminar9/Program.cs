//Теория по семинару 9
/*

*/
//Используемые функции
/*
void PrintNumber(int num)
{
    if(num == 1)
        Console.WriteLine(num);
    else
    {
        Console.Write(num + ", ");
        PrintNumber(num - 1);
    }
}
void FillingSum(int fnum, int snum, int sum)
{
    if(sum == 0)
        Console.Write($"Полученная сумма элементов от {fnum} до {snum} равна ");
    if(fnum != snum + 1)
    {
        sum = sum + fnum;
        FillingSum(fnum + 1, snum, sum);
    }
    else
        Console.WriteLine(sum);
}
int Ack(int n, int m)
{
    if(n == 0)
        return m + 1;
    else
        if(m == 0)
            return Ack(n - 1, 1);
        else
            return Ack(n - 1, Ack(n, m - 1));
}
*/
//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
Console.Write("Введите начальное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Полученная последовательность чисел от {num} до 1: ");
PrintNumber(num);
*/
//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Write("Введите начальное число: ");
int fnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int snum = Convert.ToInt32(Console.ReadLine());

int sum = 0;
FillingSum(fnum, snum, sum);
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
/*
Console.WriteLine("Данная программа определяет значение функции Аккермана для чисел n и m вида Ack(n, m)");
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int res = Ack(n, m);
Console.Write($"Значение функции с параметрами {n} и {m} равно {res}");
//При тестировании данной программы выдало ошибку Stack overflow 
//при попытке отдать значения: n > 4, m = 0 или n > 3, m > 5.
*/
//Реализация выбора желаемой задачи
/*

*/