﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите числецо");
int ugauga = Convert.ToInt32(Console.ReadLine());

if (ugauga >=1 && ugauga <= 5)
{
    //Я тут программу "минимум" сделаю. Уже устал, извините...
    Console.WriteLine("Это будний день!");
}
else if (ugauga >=6 && ugauga <=7)
{
    Console.WriteLine("Ура, выходень!");
}
else
{
    Console.WriteLine("Кому то пора отдохнуть :) В неделе не столько дней :)");
}