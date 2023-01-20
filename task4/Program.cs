//Показать четные числа от 1 до N
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int value = 1;

if(value == 1)
    {
        value += 1;
    } 

while(value <=n)
    {
        Console.WriteLine(value);
        value += 2;
    }
  