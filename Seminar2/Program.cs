//Теория по семинару 2
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

int Greeting(int nomberOfTask)
{

    if (nomberOfTask == 1)
        Console.Write("Hellow!\nInput your three-digit number: ");
    else
        Console.Write("Hellow!\nInput your number: ");
    int requestedNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("you entered a number " + requestedNumber);
    return requestedNumber;
}

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

int number1 = Greeting(1);

while(number1 < 100 || number1 > 999)
{
    Console.WriteLine("You entered an incorrect number");
    Console.Write("Input your correct three-digit number: ");
    number1 = Convert.ToInt32(Console.ReadLine());
}

int second = ((number1 / 10) % 10);
Console.WriteLine("The second digit was: " + second);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).

int number2 = Greeting(2);

if(number2 < 100)
{
    Console.WriteLine("you entered a two-digit number");
    Console.WriteLine("The third digit was: -1");
}
else
{
    while(number2 > 999)
    {
        number2 = number2 / 10;
    }
    int third = (number2 % 10);
    Console.WriteLine("The third digit was: " + third);
}

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

string[] daysOfWeek = { "Sunday", "Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday" };

int number3 = Greeting(3);

while(number3 > 7 || number3 < 1)
{
    Console.WriteLine("Your number is not the day of the week");
    Console.Write("Input a number from 1 to 7: ");
    number3 = Convert.ToInt32(Console.ReadLine());
}

if(number3 == 6 || number3 == 7)
{
    Console.WriteLine($"your day of the week is {daysOfWeek[number3 - 1] } and it's a weekend");
}
else
{
    Console.WriteLine($"your day of the week is {daysOfWeek[number3 - 1] } and it's not a weekend");
}