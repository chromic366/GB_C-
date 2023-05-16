// Напишите программу, котораяпринимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины

// Console.Write("Введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 < (num2 + num3) && (num2 < (num1 + num3)) && (num3 < (num1 + num2)))
// {
//     Console.WriteLine("Такой треугольник существеут");
// }
// else if ((num1 <= 0) || (num2 <= 0) || (num3 <=0))
// {
//     Console.WriteLine("Введите положительные числа");
// }
// else
// {
//    Console.WriteLine("Такой треугольник не существеут");
// } 


// Напишите программу, которая будет преобразовывать десятичное
// в двоичное
//  45 -> 101101
//  3 -> 22
//  2 -> 10

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string result = "";

// while (num > 0)
// {
//     result = num % 2 + result;
//     num = num / 2; 
// }
// Console.Write(result);

// Не используя рекурсию, введите первые N чмсел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 2;

// if (N >= 1)
// {
//     int[] fib = new int[N];
//     fib[0] = 0;
//     fib[1] = 1;
//     Console.Write($"{fib[0]} {fib[1] }");

//     while (i < N)
//     {
//         fib[i] = fib[i -1] + fib[i - 2];
//         Console.Write($" {fib[i] }");
//         i++;
//     }
// }

// Напишите программу, котораяперевернет одномерный массив
// (последний элемент будет на первом месте, а первый - на 
// последнем и т.д.)
// [1 2 3 4 5] - > [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = new int[5]{1, 2, 3, 4, 5};

int temp = 0;

for (int i = 0; i < array.Length / 2; i++)
{
    temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}

Console.WriteLine(String.Join(",", array));
