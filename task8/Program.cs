﻿//Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int firstDigit = n/100; //Совершаем целочисленное деление на 100. Таким образом, узнаем первую цифру числа
int lastDigit = n%10; // Находим остаток от деления на 10 - это последняя цифра числа

Console.WriteLine("После удаления второй цифры числа получилось новое число, равное " + (firstDigit*10 + lastDigit));

