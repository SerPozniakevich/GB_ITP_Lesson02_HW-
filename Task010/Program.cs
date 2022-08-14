﻿// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (1000 > num && num > 99)
{
    Console.Write($"Вторая цифра числа: {(num / 10) % 10}");
}
else
{
    Console.WriteLine($"{num} не является трёхзначным числом.");
}