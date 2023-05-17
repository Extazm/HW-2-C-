// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите числецо");
int numb = Convert.ToInt32(Console.ReadLine());
int lng = numb.ToString().Length;
Console.Write($"В числе {lng} цифр; ");
if (lng > 2)
{
    int blabla = Convert.ToInt32(Math.Pow(10, (lng - 3)));
    int agu = numb / blabla;
    agu = agu % 10;
    Console.WriteLine($"Ввели число {numb}. Третья цифра введённого числа - {agu}.");
}
else
{
    Console.WriteLine($"Ввели число {numb}. Третья цифра в данном числе отсутствует.");
}