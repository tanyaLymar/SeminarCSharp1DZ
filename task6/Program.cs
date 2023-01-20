// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int value = n/10;
if (value >= 10 & value <= 99)
    {
    value = value%10;
    Console.WriteLine("Вторая цифра введенного числа равна " + value);
    }
    else Console.WriteLine("Это не трехзначное число. Попробуйте еще раз");
