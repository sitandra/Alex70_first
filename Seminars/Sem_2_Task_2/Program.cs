/* Напишите программу, которая выводит случайное трёхзначное число и 
удаляет вторую цифру этого числа. 
456 -> 46 
782 -> 72 
918 -> 98
*/
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number} ");
int firstNumber = number / 100;
int lastNumber = number % 10;
Console.WriteLine($"Итоговое число: {firstNumber}{lastNumber} ");