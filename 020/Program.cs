// Задать номер четверти, показать диапазоны для координат 
Console.WriteLine("Задайте номер четсверти: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine($"Введенному номеру {number} четверти соответствует диапозон координат: X > 0 и Y > 0" );
}
else if (number == 2)
{
    Console.WriteLine($"Введенному номеру {number} четверти соответствует диапозон координат: X < 0 и Y > 0");
}
else if (number == 3)
{
    Console.WriteLine($"Введенному номеру {number} четверти соответствует диапозон координат: X < 0 и Y < 0");
}
else if (number == 4)
{
    Console.WriteLine($"Введенному номеру {number} четверти соответствует диапозон координат: X > 0  и Y < 0");
}
else
{
    Console.WriteLine("Вы ввели неверное значение");

}