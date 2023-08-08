//Теория по семинару 3
/*
Console.WriteLine(Math.Pow(5, 2));
Console.WriteLine(Math.Sqrt(24));
Console.WriteLine(Math.Round(Math.Sqrt(24), 2));
*/
//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
/*
bool Number()//Функция определения, является введенное число полиндромом
{
    Console.Write("Введите число на проверку: ");
    int checkedNumber = Convert.ToInt32(Console.ReadLine());//Запрос числа
    int reversCheckedNumber = 0, newCheckedNumber = checkedNumber;
    while(newCheckedNumber != 0)//Поиск развернутого введенного числа
    {
        reversCheckedNumber = reversCheckedNumber * 10 + newCheckedNumber % 10;
        newCheckedNumber = newCheckedNumber / 10;
    }
    Console.WriteLine("Вы ввели число: " + checkedNumber + "\nВаше число в развернутом виде: " + reversCheckedNumber);//Вывод развернутого числа для проверки пользователем
    if(reversCheckedNumber == checkedNumber)//Проверка, является ли число полиндромом
        return true;
    else 
        return false;
}

if(Number() == true)//Вывод работы программы
    Console.Write("Ваше число является полиндромом");
else Console.Write("Ваше число не является полиндромом");
*/
//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 3D пространстве.
/*
double [] test = new double[6];
Console.Write("Задайте координаты точки х1, y1, z1, x2, y2, z2: ");
for(int i = 0; i < 6; i++)//Ввод координат точек
{
    test[i] = Convert.ToDouble(Console.ReadLine());
}
double res = Math.Round(Math.Sqrt(Math.Pow((test[3] - test[0]), 2)+Math.Pow((test[4] - test[1]), 2)+Math.Pow((test[5] - test[2]), 2)), 4);//Расчет растояния между точками
Console.Write("Растояние между точками равно: " + res);
*/
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Задайте предел: ");
int number = Convert.ToInt32(Console.ReadLine());//Запрос предела последовательности

int current = 1;
while(current <= number)//Вывод полученной последовательности
{
    Console.Write(Math.Pow(current, 3) + " ");//Расчет куба числа
    current += 1;
}
Console.Write("- полученная последовательность.");
*/