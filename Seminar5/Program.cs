﻿// Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных 
// и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int[] numArr = new int[12];

// int positiveNum = 0;
// int negNum = 0;

// for(int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(-9, 10);

//     if (numArr[i] > 0)
//     {
//         positiveNum += numArr[i];
//     }
//     else
//     {
//         negNum += numArr[i];
//     }
// }

// Console.WriteLine(String.Join(",", numArr) +
//                 "\n Сумма положительных " + positiveNum +
//                 " отрицательных " + negNum);

// Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] numArr = new int[] {-2, 65, -345, 23, 2, -543};

// Console.WriteLine(String.Join(", ", numArr));

// for(int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] =-numArr[i];
// }
// Console.WriteLine(String.Join(",", numArr));

// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] numArr = new int[] {-2, 65, -345, 23, 2, -543};
// Console.WriteLine(String.Join(", ", numArr));

// bool flag = false;

// for(int i = 0; i < numArr.Length; i++)
// {
//     if (numArr[i] == num)
//     {
//         flag = true;
//         break;
//     }
// }

// if (flag == true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых 
// лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] numArr = new int[123];

// int num = 0;
// for(int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(0, 501);

//     if ((numArr[i] > 9) && (numArr[i] < 100))
//     {
//         num++;
//     }
// }
// Console.WriteLine(String.Join(",", numArr));
// Console.WriteLine("Количесто двухзначных чисел = " + num);

// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array1 = new int[] {3, 8, 2, 6, 5};
int[] array2 = new int[(array1.Length / 2) + (array1.Length % 2)];

for(int i = 0; i < array2.Length; i++)
{
    array2[i] = array1[i] * array1[array1.Length - 1 - i];
    if (i == array1.Length - 1 - i)
    {
        array2[i] = array1[array1.Length - 1 - i];
    }
}
Console.WriteLine(String.Join(",", array2));