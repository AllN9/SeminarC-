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
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
/*
Console.Write("Input your three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number < 100 || number > 999)
{
    Console.WriteLine("You entered an incorrect number");
    Console.Write("Input your correct three-digit number: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int second = ((number / 10) % 10);
Console.Write("The second digit was: " + second);
*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
/*
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100)
{
    Console.WriteLine("you entered a two-digit number");
    Console.WriteLine("The third digit was: -1");
}
else
{
    while(number > 999)
    {
        number = number / 10;
    }
    int third = (number % 10);
    Console.Write("The third digit was: " + third);
}
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
/*
string[] daysOfWeek = { "Sunday", "Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday" };

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 7 || number < 1)
{
    Console.WriteLine("Your number is not the day of the week");
    Console.Write("Input a number from 1 to 7: ");
    number = Convert.ToInt32(Console.ReadLine());
}

if(number == 6 || number == 7)
{
    Console.WriteLine($"your day of the week is {daysOfWeek[number - 1] } and it's a weekend");
}
else
{
    Console.WriteLine($"your day of the week is {daysOfWeek[number - 1] } and it's not a weekend");
}
*/