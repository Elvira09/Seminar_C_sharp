// По двум заданным числам проверять является ли первым квадратом второго
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine("Первое число ЯВЛЯЕТСЯ квадратом второго ");
}
else 
{
    Console.WriteLine("Первое число НЕ ЯВЛЯЕТСЯ квадратом второго ");

}