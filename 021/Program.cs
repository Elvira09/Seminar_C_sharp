// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result5 = number  %  10;
int result4 = (number  % 100) / 10;
int result2 = (number  % 10000) / 1000;
int result1 = (number  % 100000) / 10000;
if(result1 == result5 && result2 == result4)
{
    Console.WriteLine($"Введенное число {number} является палидромом");
}
else
{
    Console.WriteLine("Введенное число {0} не является палидромом", number);
}