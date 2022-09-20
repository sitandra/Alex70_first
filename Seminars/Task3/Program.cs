/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/
int number = new Random().Next(1,8);
if (number == 1) 
{
    Console.WriteLine ("1 - Понедельник!");
}
else if (number == 2) 
{
    Console.WriteLine ("2 - Вторник!");
}
else if (number == 3) 
{
    Console.WriteLine ("3 - Среда!");
}
else if (number == 4) 
{
    Console.WriteLine ("4 - Четверг!");
}
else if (number == 5) 
{
    Console.WriteLine ("5 - Пятница!");
}
else if (number == 6) 
{
    Console.WriteLine ("6 - Суббота!");
}
else if (number == 7) 
{
    Console.WriteLine ("7 - Воскресенье!");
}