//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");

if(firstNumber%secondNumber == 0) Console.WriteLine(firstNumber + " кратно " +secondNumber);
else Console.WriteLine("Остаток от деления равен " + firstNumber%secondNumber + ". Число " + firstNumber + " не кратно " + secondNumber);

