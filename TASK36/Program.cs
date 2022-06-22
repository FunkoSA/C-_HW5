/*
    Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

 [3, 7, 23, 12] -> 19
 [-4, -6, 89, 6] -> 0

По своей сути задача можно решить двумя способами:
1) Используя 3 метода (заполнение массива, вывод сформированного массива и метод подсчета суммы четных элементов массива)
2) используя 2 метода (заполнение массива, метод подсчета суммы четных элементов массива) и вывод результата с помошью встроенного в C# метода String.Join
Для решения использован исходный код из задачи 34

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
WriteLine($"Сумма чётных элементов = {SumEvenElements(arrayN)}");

//String.Join работает только с одномерными массивами
WriteLine("Вариант решения №2");
WriteLine($"В массиве из {A} элемонтов [{String.Join(",",arrayN)}] сумма чётных элементов = {SumEvenElements(arrayN)}");


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

//Описание метода подсчета четных значений элементов, сформированного массива
int SumEvenElements(int[] array)
{
    int SumElements = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        SumElements+=array[i];
    }
    
    return SumElements;
}