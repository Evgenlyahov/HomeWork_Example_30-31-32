// 30. Показать кубы чисел, заканчивающихся на четную цифру

int digit = new Random().Next(1, 21);
System.Console.WriteLine($"Случайное число {digit}");
int kub = digit*digit*digit;
if (kub%2 == 0)
{
    System.Console.WriteLine($"Куб числа {digit} оканчивается на чётную цифру и равен {kub}");
}
else
{
    System.Console.WriteLine($"Куб числа {digit} оканчивается на нечётную цифру");
}