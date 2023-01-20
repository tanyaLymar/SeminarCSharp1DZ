//Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Последняя цифра введенного числа равна " + n%10);

