//Теория по семинару 6
/*

*/
//Используемые функции
/*

*/
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int RequestNumber(string message)//Функция приветственного сообщения и запроса числа
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вы ввели число: " + number);//Вывод введенного числа для проверки пользователем
    return number;
}
int [] FillingTheArray(int length, int operation)//Функция заполнения массива
{
    int [] array = new int[length];
    if(operation == 0)//Заполнение массива самостоятельно
    {
        Console.Write("Задайте массив: ");
        for(int i = 0; i < length; i++)//Цикл запрос данных в массив
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    else
    {
        Console.Write("Задайте нижний и верхний предел, в котором будут выбираться случайные числа: ");//Запрос пределов заполнения случайными числами
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < length; i++)//Цикл заполнения массива случайными числами в заданном диапазоне
        {
            array[i] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void OutputRes(int [] mas, int operation, int length)//Функция вывода результата заполнения массива для проверки пользователем
{
    if(operation == 1)
        Console.Write("Полученный массив из случайных чисел: [");
    else
        Console.Write("Введенный вами массив: [");
    for(int i = 0; i < length - 1; i++)
    {
        Console.Write(mas[i] + ", ");
    }
    Console.WriteLine(mas[length - 1] + "]");
}
void QuantitySearch(int [] mas, int length)
{
    int quantity = 0;
    for(int i = 0; i < length; i++)
    {
        if(mas[i] < 0)
        quantity++;
    }
    Console.WriteLine($"Количество отрицательных чисел равно {quantity}");
}

int length = RequestNumber("Введите размер массива: ");//Запрос размера массива
Console.Write("Введите 1, чтобы заполнить массив случайыми числами, или 0, чтобы заполнить его самостоятельно: ");
int operation = Convert.ToInt32(Console.ReadLine());//Определение условия заполнения
int [] mas = FillingTheArray(length, operation);//Заполнение массива согласно условию
OutputRes(mas, operation, length);//Вывод результата
QuantitySearch(mas, length);//Подсчет колличества отрицательных чисел
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



//Реализация выбора желаемой задачи
/*

*/