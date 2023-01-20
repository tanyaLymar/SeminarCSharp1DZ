//Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int mod = 0;
int newNumber = 0;
int i = 0;
for(i=n; n!=0; n=n/10)
        {
        mod = n%10;
        newNumber = newNumber*10 + mod;
        }
int thirdDigit = newNumber/100%10;      

if (newNumber/10 < 10) Console.WriteLine("Третьей цифры у числа нет.");
else Console.WriteLine(thirdDigit);

