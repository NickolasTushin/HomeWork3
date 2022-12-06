//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.WriteLine("Введите пятизначное число: ");

string? n = Console.ReadLine();  
if (n!.Length > 5 || n!.Length < 5)
{
    Console.WriteLine($"Введите правильное число");
}
else if (n[0]==n[4] || n[1]==n[3])
{
    Console.Write($"Ваше число {n} - палиндром ");
}
else
{
Console.Write($"Ваше число {n} не палиндром ");
}
