// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number  % 100) / 10;
Console.WriteLine("Вторая цифра введенного числа: " + result);

/* Вариант решенный на совместном ДЗ

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (99 < a && a < 1000)
{
   int result = (a % 100)/10; 
Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка");
}
*/
