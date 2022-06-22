

/*
    Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

 [3 7 22 2 78] -> 76


По своей сути задача можно решить двумя способами:
1) Используя 3 метода (заполнение массива, вывод сформированного массива и метод подсчета четных значений элементов массива)
2) используя 2 метода (заполнение массива, метод подсчета четных значений элементов массива) и вывод результата с помошью встроенного в C# метода String.Join
По лучшей традиции для решения использован исходный код из задачи 34 предыдущей домашней работы
*/

using System;
using  static System.Console;

Clear();
WriteLine("Данная программа осуществляет заполнение одномерного массива и выводит его на экран");
Write("Введите из какого количества элементов необходимо сформировать массив: ");
int A = int.Parse(ReadLine());
WriteLine("Массив будет сформирован с помощью генератора случайных чисел.");
Write("Введите минимальное возможное значение элемента для заполнения массива: ");
int minValue = int.Parse(ReadLine());
Write("Введите максимаьное возможное значение элемента для заполнения массива: ");
int maxValue = int.Parse(ReadLine());

//Заполним массив используя описанный ниже метод
int[] arrayN = GetRandomArray(A,minValue,maxValue);


WriteLine("Вариант решения №1");
WriteLine($"В массиве из {A} элемонтов ");
PrintArray(arrayN);
DiffMaxMin(arrayN);
WriteLine();

//String.Join работает только с одномерными массивами
WriteLine("Вариант решения №2");
WriteLine($"В массиве из {A} элемонтов [{String.Join(",",arrayN)}]");
DiffMaxMin(arrayN);
WriteLine();


// Описание метода вывода на экран массива
void PrintArray (int[] array)
{
    Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]},"); 
    }
    WriteLine($"{array[array.Length - 1]}]");
}

//Описание метода заполнения массива из N элементов генератором случайных чисел
int[] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i =0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }

    return result;
}

//Описание метода нахождения максимального и минимального значения элементов массива и вывода их разницы
void DiffMaxMin (int[] array)
{
    int min = array[0];
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        else 
        {
            if (max < array[i]) max = array[i];
        }
    }

    Write($"Разница между максимальным элементом массива {max} и минимальным элементом массива {min} = {max - min}");
}