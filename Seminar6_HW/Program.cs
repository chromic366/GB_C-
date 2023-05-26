//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//  Console.Write("Введите числа через пробел: ");
//         string input = Console.ReadLine();
//         string[] numbers = input.Split(' ');

//         int count = 0;
//         foreach (string number in numbers)
//         {
//             if (float.Parse(number) > 0)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"Количество чисел больше нуля: {count}");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 Console.WriteLine("Enter the values of k1, b1, k2, and b2:");

            // считываем значения коэффициентов прямых
            double k1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double k2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());

            // вычисляем координаты точки пересечения прямых
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            // выводим результаты
            Console.WriteLine("The point of intersection is at ({0}, {1})", x, y);