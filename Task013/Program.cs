// Задача 13. Напишите программу, которая выводит третью цифру заданного числа, 
// или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");

int num = Math.Abs (Convert.ToInt32(Console.ReadLine()));

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}

else
{
    int div = 10;
    while (( num / div ) >= 99 )
    {
    

     num = num / div;

   
    
    }
   Console.Write( num % div ); 
}

