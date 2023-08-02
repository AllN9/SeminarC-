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

int RequestТumber(int nomberOfTask)
{

    if (nomberOfTask == 1)
        Console.Write("Hellow!\nInput your three-digit number: ");
    else
        Console.Write("Hellow!\nInput your number: ");
    int requestedNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("You entered a number " + requestedNumber);
    return requestedNumber;
}
int ErrorChecking(int nomberOfTask, int requestedNumber)
{
    int correctRequestedNumber = requestedNumber;
    if (nomberOfTask == 1)
        while(correctRequestedNumber < 100 || correctRequestedNumber > 999)
        {
            Console.WriteLine("You entered an incorrect number");
            Console.Write("Input your correct three-digit number: ");
            correctRequestedNumber = Convert.ToInt32(Console.ReadLine());
        }
        else
            if(nomberOfTask == 2)
            {
                if(correctRequestedNumber < 100)
                    Console.WriteLine("you entered a two-digit number\nThe third digit was: -1");
                return correctRequestedNumber;
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

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

int number1 = RequestТumber(1);

int correctNumber1 = ErrorChecking(1, number1);

correctNumber1 = ((correctNumber1 / 10) % 10);
Console.WriteLine("The second digit was: " + correctNumber1);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).

int number2 = RequestТumber(2);

int correctNumber2 = ErrorChecking(2, number2);

while(correctNumber2 > 999)
{
    correctNumber2 = correctNumber2 / 10;
}
int third = (correctNumber2 % 10);
Console.WriteLine("The third digit was: " + correctNumber2 % 10);

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

string[] daysOfWeek = { "Sunday", "Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday" };

int number3 = RequestТumber(3);

int correctNumber3 = ErrorChecking(3, number3);

if(correctNumber3 == 6 || correctNumber3 == 7)
{
    Console.WriteLine($"your day of the week is {daysOfWeek[correctNumber3 - 1] } and it's a weekend");
}
else
{
    Console.WriteLine($"your day of the week is {daysOfWeek[correctNumber3 - 1] } and it's not a weekend");
}