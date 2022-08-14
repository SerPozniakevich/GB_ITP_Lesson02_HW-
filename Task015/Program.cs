// Задача 15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите цифру обозначающую день недели (от 1 до 7): ");
int numDay = Convert.ToInt32(Console.ReadLine());
if (1 > numDay || 8 < numDay)
{
    Console.WriteLine($"Нет дней, соответствующих номеру : {numDay} " );
}
else if (numDay == 6 || numDay == 7)
{
    Console.WriteLine($"День подномером : {numDay} является выходным");
}
else
{
    Console.WriteLine($"День подномером : {numDay} не является выходным");
}