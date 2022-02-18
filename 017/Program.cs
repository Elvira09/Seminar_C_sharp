// По двум заданным числам проверять является ли одно квадратом другого числа

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2)
{
    Console.WriteLine($"Введенное число {number2} является квадратом числа {number1} ");
}
else
{
    Console.WriteLine($"Введенное число {number2} является квадратом числа {number1} ");
}


