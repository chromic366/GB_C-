// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Write("Ведите пятизначное число: ");
// string number = Convert.ToString(Console.ReadLine());

// if ((number[0] == number[4]) && (number[1] == number[3]))
// {
//     Console.WriteLine("Число является полиндромом");    
// }
// else
// {
//     Console.WriteLine("Число не является полиндромом");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите число: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int x2 = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите число: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 2);

Console.WriteLine(d);







// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125