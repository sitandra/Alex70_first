﻿/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int Result = firstNumber % secondNumber;
if (Result == 0)
{
    Console.WriteLine("Число кратно!");
}
else 
{
    Console.WriteLine ($"Число не кратно, остаток равен {Result}.");
}