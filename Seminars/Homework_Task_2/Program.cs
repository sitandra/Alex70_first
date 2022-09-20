/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.Write("Введите число A: ");
int namberA = new Random().Next(1, 100);
Console.WriteLine(namberA);
Console.Write("Введите число B: ");
int namberB = new Random().Next(1, 100);
Console.WriteLine(namberB);
int max = namberA;
if (namberA > namberB)
{
    Console.WriteLine($"Число max: {max}");
}
else 
{
    Console.Write($"Число max: {namberB}");
}