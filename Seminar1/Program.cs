//Теория по семинару 1 
/*
Console.WriteLine("Привет мир");
int intNumber = 25;
double doubleNumber = 25.25;
string text = "Some text";
bool logicVar = true;

int num = 5;
Console.WriteLine(num);
Console.WriteLine("My number is " + num + " )");
Console.WriteLine($"My number is {num} )"); //форматированный вывод

Console.Write("input a number: ");//все, что вводится и выводится из консоли, получает тип строка
int num = Convert.ToInt32(Console.ReadLine());//конвертация строки в нужный тип для записи

Console.WriteLine("input a number: " + num);
*/
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());//Ввод первого числа
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());//Ввод второго числа

if(num1 >= num2)//Поиск наибольшего из двух чисел
{
    Console.WriteLine("max number is the first number - " + num1);//Вывод если первое больше
}
else
{
    Console.WriteLine("max number is the second number - " + num2);//Вывод если второе больше
}
*/
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());//Ввод первого числа
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());//Ввод второго числа
Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());//Ввод третьего числа

int max = num1;
if(max < num2)
max = num2;
if(max < num3)
max = num3;//Поиск максимального числа из трех представленных

Console.Write("max of yuor entered number is " + max);//Вывод найденого максимального числа
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());//Ввод числа на проверку

if(num % 2 == 0)//Проверка числа на кратность двум
{
    Console.WriteLine("Your number is even.");//Вывод, что число четное
}
else
{
    Console.WriteLine("Your number is odd.");//Вывод, что число не четное
}
*/
//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());//Запрос предельного числа

int current = 2;//Определение минимального четного числа как 2
while(current <= num)//Вывод последовательности четных чисел от 1 до N
{
    Console.Write(current + " ");
    current += 2;
}
*/