/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int getRandomNumberFromRange(int firstNumber, int lastNumber)
{
    int result = new int();
    result = new Random().Next(firstNumber, lastNumber + 1);
    return result;
}
int getThirdDigitFromNumber(int number)
{
    int thirdDigit = 0;
    while (number > 0)
    {
        int result = number / 10;
        if (result > 1000)
        {
            int threeDigit = number / 100;
            thirdDigit = thirdDigit + (threeDigit % 10);
        }
        else
        {
            int result1 = number / 10;
            if (result1 > 100)
            {
                int threeDigit = number / 10;
                thirdDigit = thirdDigit + (threeDigit % 10);
            }
            else
            {
                int result2 = number / 10;
                if (result2 > 10)
                {
                    int threeDigit = number;
                    thirdDigit = thirdDigit + (threeDigit % 10);
                }
                else
                {
                    thirdDigit = -1;
                }
                return thirdDigit;
            }
            return thirdDigit;
        }
        return thirdDigit;
    }
    return thirdDigit;
}
int randomNumber = getRandomNumberFromRange(10, 999999);
Console.WriteLine($"Случайное заданное число: {randomNumber}");
int thirdDigit = getThirdDigitFromNumber(randomNumber);
if (thirdDigit < 0)
{
    Console.WriteLine($"В заданном числе {randomNumber} третья цифра отсутствует!");
}
else
{
    Console.WriteLine($"В заданном числе {randomNumber} третья цифра {thirdDigit}!");
}