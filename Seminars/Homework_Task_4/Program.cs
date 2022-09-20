/*Задача 4: Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);
int numberC = new Random().Next(1, 100);
Console.WriteLine($"Введите три числа: {numberA}, {numberB}, {numberC}");
int max = numberA;
if (numberB > numberA)
{
    max = numberB;
    if (numberC > numberB)
    {
        max = numberC;
    }
    else if (numberC > numberA)
    {
        max = numberC;
    }
    else 
    max = numberB;
}
Console.WriteLine($"Число max: {max}");