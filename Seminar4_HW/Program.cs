// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите степень: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int Exponentiate()
// {
//     double result = Math.Pow(num1, num2);
//     return Convert.ToInt32(result);
// }

// Console.WriteLine(Exponentiate());


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }

// int SumAll(int number)
// {
//     int result = 0;
//     while (number > 0) 
//     {
//         result += number % 10;
//         number = number / 10;
//     } 
//     return result;
// }

// int number = Prompt("Введите число: ");
// System.Console.WriteLine($"Суммв всех чисел в цифре {number} = {SumAll(number)} ");

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение, для  диапазона случайного числа: ");
int max = Prompt("Начальное значение, для  диапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array); 