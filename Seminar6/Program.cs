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
void QuantitySearch(int [] mas, int length)//функция поиска количества отрицательных чисел
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
/*
double[] Greeting()//функция запроса чисел для работы программы
{
    Console.WriteLine("Две прямые задаются уравнениями y = k1 * x + b1 и y = k2 * x + b2.");
    Console.Write("Задайти значения k1, k2, b1, b2: ");
    double []mas = new double[4];
    for(int i=0; i < 4; i++)//запрос коэфициентов
        mas[i] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Вы ввели числа: ");
    for(int i=0; i < 3; i++)//вывод введенных данных
        Console.Write(mas[i] + ", ");
    Console.WriteLine(mas[3] + "");
    Console.WriteLine("Полученные уравнения выглядят так:");
    Console.WriteLine($"1) y = {mas[0]} * x + {mas[2]}");
    Console.WriteLine($"2) y = {mas[1]} * x + {mas[3]}");
    return mas;
}
void MatesSearch(double[] mas)
{
    double [] cord = new double[2];
    if(mas[0] != mas[1])
        {
            cord[0] = (mas[3] - mas[2])/(mas[0] - mas[1]);
            cord[1] = mas[0] * cord[0] + mas[2];
            Console.WriteLine($"Координаты точки пересечения прямых: [{cord[0]}, {cord[1]}]");
        }
    else 
        Console.WriteLine("У заданных прямых нет общих точек, а значит они параллельны");
}
double[] cord = Greeting();
MatesSearch(cord);
*/
//Реализация выбора желаемой задачи
/*

*/