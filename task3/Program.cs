﻿//Выяснить является ли число четным
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number%2 == 0) Console.WriteLine("Введенное число является четным");
else Console.WriteLine("Введенное число является нечетным");
