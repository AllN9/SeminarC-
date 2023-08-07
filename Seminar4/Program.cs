//Теория по семинару 4
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
void ConstructionCycle(int baseNum, int degree)
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
ConstructionCycle(baseNum, degree);
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
int [] FillingTheArray(int length, int operation)
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
void OutputRes(int [] mas, int operation, int length)
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
int [] mas = FillingTheArray(length, operation);
OutputRes(mas, operation, length);
*/
//Реализация выбора желаемой задачи
/*
int Greeting()
{
    Console.Write("Enter the number of the desired task or enter 0 to finish the program: ");
    int numberOfTask = Convert.ToInt32(Console.ReadLine());
    while(numberOfTask != 25 && numberOfTask != 27 && numberOfTask != 29 && numberOfTask != 0)
    {
        Console.WriteLine("There is no task with this number\nTask list: 25, 27, 29");
        Console.Write("Enter the correct number of the desired task or enter 0 to finish the program: ");
        numberOfTask = Convert.ToInt32(Console.ReadLine());
    }
    return numberOfTask;
}
int [] RequestNumber(int numberOfTask)
{
    if(numberOfTask == 25)
    {
        int [] requestNum = new int [2];
        Console.Write("Введите ваше число: ");
        requestNum[0] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Вы ввели: " + requestNum[0]);
        Console.Write("Введите степень, в которую вы хотите возвести это число: ");
        requestNum[1] = Convert.ToInt32(Console.ReadLine());
        return requestNum;
    }
    else
        if(numberOfTask == 27)
        {
            int [] requestNum = new int [1];
            Console.Write("Введите ваше число: ");
            requestNum[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + requestNum[0]);
            return requestNum;
        }
        else
        {
            int [] requestNum = new int [1];
            Console.Write("Введите размер массива: ");
            requestNum[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + requestNum[0]);
            return requestNum;
        }
}
void ConstructionCycle(int [] requestNum)
{
    int current = requestNum[0];
    Console.WriteLine($"Ход работы программы по возведению числа {requestNum[0]} в степень {requestNum[1]}: ");
    for(int i = 0; i < requestNum[1]; i++)
    {
        Console.Write(current + " ");
        current = current * requestNum[0];
    }
    Console.WriteLine("");
    Console.WriteLine($"Число {requestNum[0]} в степени {requestNum[1]} равно {Math.Pow(requestNum[0], requestNum[1])}");
}
void SearchSum(int [] requestNum)
{
    int sum = 0, current = requestNum[0];
    while(current != 0)
    {
        sum = sum + current % 10;
        current = current / 10;
    }
    Console.WriteLine("Сумма цифр вашего числа равно: " + sum);
}
int [] FillingTheArray(int [] requestNum, int operation)
{
    int [] array = new int[requestNum[0]];
    if(operation == 0)
    {
        Console.Write("Задайте массив: ");
        for(int i = 0; i < requestNum[0]; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    else
    {
        Console.Write("Задайте нижний и верхний предел, в котором будут выбираться случайные числа: ");
        int min = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < requestNum[0]; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void OutputRes(int [] mas, int operation, int [] requestNum)
{
    if(operation == 1)
        Console.Write("Полученный массив из случайных чисел: [");
    else
        Console.Write("Введенный вами массив: [");
    for(int i = 0; i < requestNum[0] - 1; i++)
    {
        Console.Write(mas[i] + ", ");
    }
    Console.WriteLine(mas[requestNum[0] - 1] + "]");
}

Console.WriteLine("Hello!");
int numberOfTask = Greeting();

while(numberOfTask != 0)
{
    int [] requestNum = RequestNumber(numberOfTask);
    if(numberOfTask == 25)
        ConstructionCycle(requestNum);
    else
        if(numberOfTask == 27)
            SearchSum(requestNum);
        else
        {
            Console.Write("Введите 1, чтобы заполнить массив случайыми числами, или 0, чтобы заполнить его самостоятельно: ");
            int operation = Convert.ToInt32(Console.ReadLine());
            int [] mas = FillingTheArray(requestNum, operation);
            OutputRes(mas, operation, requestNum);
        }
    numberOfTask = Greeting();
}

Console.WriteLine("Bye-Bye!");
*/