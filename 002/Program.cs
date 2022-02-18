// Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
int min = numberB;
if (numberB > numberA)
{
    max = numberB;
    min = numberA;
}
Console.WriteLine("Максимальное число равно: ");
Console.WriteLine(max);
Console.WriteLine("Минимальное число равно: ");
Console.WriteLine(min);

