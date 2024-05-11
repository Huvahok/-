﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// // [“Russia”, “Denmark”, “Kazan”] → []
string[] array = {"Russia","Denmark","Kazan", "random words","important word"};
string[] Newarray = new string[3];
Newarray[0] = array[1];
Newarray[1] = array[3];
Newarray[2] = array[4];
foreach(string i in Newarray)
{
    System.Console.Write(i+", ");
}