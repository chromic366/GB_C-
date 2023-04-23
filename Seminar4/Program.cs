// Напишите программу, которая принимае на вход число (А)
// и выдаёт сумму чисел от 1 до А.

// Console.Write("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int GetSumNum ()
// {
//     int sum = 0;
//     int count = 0;

//     while (number > count)
//     {
//         count++;
//         sum += count;
//     }

//     return sum;
// }

// Console.WriteLine(GetSumNum());



// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int  NumCount(int num)
// {
//     return Convert.ToString(num).Length;
// }

// Console.Write("Введите число: ");
// Console.WriteLine(NumCount(Convert.ToInt32(Console.ReadLine())));

// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int GeNumCount()
// {
//     int  i = 0 ;
//     while (num1 != 0)
//     {
//         num1 /= 10;
//         i++;
//     }
//     return i;
// }
// Console.WriteLine(GeNumCount());


// Напишите программу, которая принимает на вход число N 
// и выдает произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

// Console.Write("Введите число: ");
// int num =  Convert.ToInt32(Console.ReadLine());
// int temp = 1;

// for(int i = 1; i<=num; i++)
// {
//     temp = temp * i;
// }

// Console.WriteLine(temp);

// напишите программу, которая выводит массив из 8 элементов,
// заполненными нулями и единицами в случайном порядке.
// [1,0,0,1,0,1,1,0]

int [] array = new int[8];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    
}
Console.Write(String.Join(", ", array));


