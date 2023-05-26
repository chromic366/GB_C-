// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int m = 3; // количество строк
// int n = 4; // количество столбцов

// double[,] array = new double[m, n]; // объявление массива

// Random random = new Random(); // объект для генерации случайных чисел

// // заполнение массива случайными вещественными числами
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = random.NextDouble();
//     }
// }

// // вывод массива в консоль
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine(); 
// }

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


// int[,] array = new int[,]
// {
//     { 1, 4, 7, 2 },
//     { 5, 9, 2, 3 },
//     { 8, 4, 2, 4 }
// };

// Console.Write("Введите номер строки: ");
// int row = int.Parse(Console.ReadLine()) - 1; // вычитаем 1, чтобы учитывать нумерацию с 0
// Console.Write("Введите номер столбца: ");
// int column = int.Parse(Console.ReadLine()) - 1; // вычитаем 1, чтобы учитывать нумерацию с 0

// if (row >= 0 && row < array.GetLength(0) &&
//     column >= 0 && column < array.GetLength(1))
// {
//     Console.WriteLine("Значение элемента: " + array[row, column]);
// }
// else
// {
//     Console.WriteLine("Элемент не найден!");
// }

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int[,] array = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

double[] averages = new double[array.GetLength(1)];

for (int j = 0; j < array.GetLength(1); j++)
{
    double columnSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        columnSum += array[i, j];
    }

    averages[j] = columnSum / array.GetLength(0);
}

Console.WriteLine("Средние арифметические значения элементов в каждом столбце:");

for (int j = 0; j < array.GetLength(1); j++)
{
    Console.WriteLine($"Столбец {j + 1}: {averages[j]}");
}
