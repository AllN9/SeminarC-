﻿//Теория по семинару 2
/*

*/
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.



//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.



//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

Console.Write("Введите размер массива: ");
int count = Convert.ToInt32(Console.ReadLine());
int [] mas = new int[count];
Console.Write("Задайте массив: ");
for(int i = 0; i < count; i++)
{
    mas[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введенный вами массив: ");
for(int i = 0; i < count; i++)
{
    Console.Write(mas[i] + " ");
}
