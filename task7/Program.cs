//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10,100);
Console.WriteLine("Случайным образом было выбрано число: " + number);
int firstDigit = number/10; //совершаем целочисленное деление на 10 
int secondDigit = number%10; //находим остаток от деления на 10
if (firstDigit > secondDigit) Console.WriteLine("В этом числе наибольшей является цифра " + firstDigit);
else if (firstDigit < secondDigit) Console.WriteLine ("В этом числе наибольшей является цифра " + secondDigit);
else Console.WriteLine("В этом числе обе цифры равны"); 
