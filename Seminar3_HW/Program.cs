// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Ведите пятизначное число: ");
string number = Convert.ToString(Console.ReadLine());

if ((number[0] == number[4]) && (number[1] == number[3]))
{
    Console.WriteLine("Число является полиндромом");    
}
else
{
    Console.WriteLine("Число не является полиндромом");
}