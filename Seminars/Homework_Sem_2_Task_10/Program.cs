/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число: {number} ");
int firstTwoNumber = number / 10;
int secondNumber = firstTwoNumber % 10;
Console.WriteLine($"Вторая цифра указанного числа: {secondNumber}!");