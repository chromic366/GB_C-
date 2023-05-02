// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] numArr = new int[20];

// int count = 0;

// for(int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(100, 1000);

//     if (numArr[i] % 2 == 0) 
//     {
//         count++;
//     }
// }

// Console.WriteLine(String.Join(",", numArr) +
//                 "\nКоличество четных чисел = " + count);



//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] numArr = new int[7];

// int count = 0;

// for(int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(-99, 100);
// }

//     for (int j = 1; j < numArr.Length; j+=2)
// //  if (numArr[i] % 2 != 0) 
//     {
//         count = count + numArr[j];
//     }

// Console.WriteLine(String.Join(",", numArr) +
//                 "\nCумма элементов, стоящих на нечётных позициях = " + count);


//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] numArr = new double[7];

for(int i = 0; i < numArr.Length; i++)
{
    numArr[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
}

double min = numArr[0];
double max = numArr[0];

for(int j = 0; j < numArr.Length; j++)
{
    if(numArr[j] > max)
    {
        max = numArr[j];
    }
    if(numArr[j] < min)
    {
        min = numArr[j];
    }
}

Console.WriteLine(String.Join(", ", numArr));
Console.WriteLine("Разница между максимальным элементом ("  + max + ") и минимальным элементом (" + min +") = " + (max - min));