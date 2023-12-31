﻿//Теория по семинару 2
/*
int CutNumber(int num)
{
    int handreds = num / 100;
    int units = num % 10;

    return handreds * 10 + units;
}

int randNumber = new Random().Next(100, 1000);

Console.WriteLine(CutNumber(randNumber));
Console.Write("Вначале было число " + randNumber);
*/
//Используемые функции
/*
int RequestТumber(int nomberOfTask)//Функция запроса данных у пользователя
{

    if (nomberOfTask == 1)//Определение вывода приветственной фразы для выбранной задачи
        Console.Write("Hellow!\nInput your three-digit number: ");
    else
        Console.Write("Hellow!\nInput your number: ");
    int requestedNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("You entered a number " + requestedNumber);//Вывод введенного числа для проверки пользователем
    return requestedNumber;
}
int ErrorChecking(int nomberOfTask, int requestedNumber)//Функция избежания ошибок
{
    int correctRequestedNumber = requestedNumber;
    if (nomberOfTask == 1)//Проверка ошибок первой задачи
        while(correctRequestedNumber < 100 || correctRequestedNumber > 999)//Определение, является ли число трехзначным
        {
            Console.WriteLine("You entered an incorrect number");
            Console.Write("Input your correct three-digit number: ");
            correctRequestedNumber = Convert.ToInt32(Console.ReadLine());
        }
        else
            if(nomberOfTask == 2)//Проверка ошибок второй задачи
            {
                if(correctRequestedNumber < 100)//Определение, является ли число двузначным
                    Console.WriteLine("You entered a two-digit number");
                return -1;
            }
            else//Проверка ошибок третьей задачи
                while(correctRequestedNumber > 7 || correctRequestedNumber < 1)//Определение, является ли число номером дня недели
                {
                    Console.WriteLine("Your number is not the day of the week");
                    Console.Write("Input a number from 1 to 7: ");
                    correctRequestedNumber = Convert.ToInt32(Console.ReadLine());
                }
    return correctRequestedNumber;
}
*/
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
/*
int number1 = RequestТumber(1);//Запрос трехзначного числа

int correctNumber1 = ErrorChecking(1, number1);//Проверка, является ли число трехзначным

correctNumber1 = ((correctNumber1 / 10) % 10);//Определение и вывод второй цифры заданного числа
Console.WriteLine("The second digit was: " + correctNumber1);
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
/*
int number2 = RequestТumber(2);//Запрос числа

int correctNumber2 = ErrorChecking(2, number2);//Проверка условия задачи

while(correctNumber2 > 999)//Поиск третьей цифры
    correctNumber2 = correctNumber2 / 10;
int third = (correctNumber2 % 10);//Определение третьей цифры
Console.WriteLine("The third digit was: " + third);
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
/*
string[] daysOfWeek = { "Sunday", "Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday" };

int number3 = RequestТumber(3);//Запрос числа

int correctNumber3 = ErrorChecking(3, number3);//Проверка коректности ввода

if(correctNumber3 == 6 || correctNumber3 == 7)//Вывод результата согласно условию
    Console.WriteLine($"your day of the week is {daysOfWeek[correctNumber3 - 1] } and it's a weekend");
else
    Console.WriteLine($"your day of the week is {daysOfWeek[correctNumber3 - 1] } and it's not a weekend");
*/
//Реализация выбора желаемой задачи
/*
int Greeting()
{
    Console.Write("Enter the number of the desired task or enter 0 to finish the program: ");
    int numberOfTask = Convert.ToInt32(Console.ReadLine());
    while(numberOfTask != 10 && numberOfTask != 13 && numberOfTask != 15 && numberOfTask != 0)
    {
        Console.WriteLine("There is no task with this number\nTask list: 10, 13, 15");
        Console.Write("Enter the correct number of the desired task or enter 0 to finish the program: ");
        numberOfTask = Convert.ToInt32(Console.ReadLine());
    }
    return numberOfTask;
}
int RequestТumber(int numberOfTask)
{
    if (numberOfTask == 10)
        Console.Write("Input your three-digit number: ");
    else
        Console.Write("Input your number: ");
    int requestedNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("You entered a number " + requestedNumber);
    return requestedNumber;
}
int ErrorChecking(int numberOfTask, int requestedNumber)
{
    int correctRequestedNumber = requestedNumber;
    if (numberOfTask == 10)
        while(correctRequestedNumber < 100 || correctRequestedNumber > 999)
        {
            Console.WriteLine("You entered an incorrect number");
            Console.Write("Input your correct three-digit number: ");
            correctRequestedNumber = Convert.ToInt32(Console.ReadLine());
        }
        else
            if(numberOfTask == 13)
            {
                if(correctRequestedNumber < 100)
                {
                    Console.WriteLine("You entered a two-digit number");
                    return -1;
                }
            }
            else
                while(correctRequestedNumber > 7 || correctRequestedNumber < 1)
                {
                    Console.WriteLine("Your number is not the day of the week");
                    Console.Write("Input a number from 1 to 7: ");
                    correctRequestedNumber = Convert.ToInt32(Console.ReadLine());
                }
    return correctRequestedNumber;
}
void TaskSolution(int numberOfTask, int correctRequestedNumber)
{
    if(numberOfTask == 10)
    {
        correctRequestedNumber = ((correctRequestedNumber / 10) % 10);
        Console.WriteLine("The second digit was: " + correctRequestedNumber);
    }
    else
    {
        if(numberOfTask == 13)
        {
            while(correctRequestedNumber > 999)
                correctRequestedNumber = correctRequestedNumber / 10;
            int third = (correctRequestedNumber % 10);
            Console.WriteLine("The third digit was: " + third);
        }
        else
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday" };
            if(correctRequestedNumber == 6 || correctRequestedNumber == 7)
                Console.WriteLine($"your day of the week is {daysOfWeek[correctRequestedNumber - 1] } and it's a weekend");
            else
                Console.WriteLine($"your day of the week is {daysOfWeek[correctRequestedNumber - 1] } and it's not a weekend");
        }
    }
}

Console.WriteLine("Hello!");
int numberOfTask = Greeting(), requestedNumber, correctRequestedNumber;//Начальное определение действий программы

while(numberOfTask != 0)//Цыкл выбора желаемой задачи
{
    requestedNumber = RequestТumber(numberOfTask);//Запрос числа для выбранной задачи
    correctRequestedNumber = ErrorChecking(numberOfTask, requestedNumber);//Проверка корректности ввода
    TaskSolution(numberOfTask, correctRequestedNumber);//Решение задачи
    numberOfTask = Greeting();//Повтор выбора желаемой задачи или выход из программы
}

Console.WriteLine("Bye-Bye!");
*/