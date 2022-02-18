// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Введенное число {number} делится на 7 и 23");
}
else
{
    Console.WriteLine($"Введенное число {number} не делится на 7 и 23");
}
