//Теория по семинару 2
/*

*/
//Используемые функции
/*
int RequestNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вы ввели число: " + number);
    return number;
}
*/
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void constructionCycle(int baseNum, int degree)
{
    int current = baseNum;
    Console.WriteLine($"Ход работы программы по возведению числа {baseNum} в степень {degree}: ");
    for(int i = 0; i < degree; i++)
    {
        Console.Write(current + " ");
        current = current * baseNum;
    }
    Console.WriteLine("");
}

int baseNum = RequestNumber("Введите ваше число: ");
int degree = RequestNumber("Введите степень, в которую вы хотите возвести это число: ");
constructionCycle(baseNum, degree);
Console.WriteLine($"Число {baseNum} в степени {degree} равно {Math.Pow(baseNum, degree)}");
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SearchSum(int num)
{
    int sum = 0, current = num;
    while(current != 0)
    {
        sum = sum + current % 10;
        current = current / 10;
    }
    return sum;
}

int num = RequestNumber("Введите ваше число: ");
int res = SearchSum(num);
Console.WriteLine("Сумма цифр вашего числа равно: " + res);
*/
//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int [] fillingTheArray(int length, int operation)
{
    int [] array = new int[length];
    if(operation == 0)
    {
        Console.Write("Задайте массив: ");
        for(int i = 0; i < length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    else
    {
        Console.Write("Задайте нижний и верхний предел, в котором будут выбираться случайные числа: ");
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < length; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void outputRes(int [] mas, int operation, int length)
{
    if(operation == 1)
        Console.Write("Полученный массив из случайных чисел: [");
    else
        Console.Write("Введенный вами массив: [");
    for(int i = 0; i < length - 1; i++)
    {
        Console.Write(mas[i] + ", ");
    }
    Console.Write(mas[length - 1] + "]");
}

int length = RequestNumber("Введите размер массива: ");
Console.Write("Введите 1, чтобы заполнить массив случайыми числами, или 0, чтобы заполнить его самостоятельно: ");
int operation = Convert.ToInt32(Console.ReadLine());
int [] mas = fillingTheArray(length, operation);
outputRes(mas, operation, length);
*/