// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
//int result = number % 10;
//Console.WriteLine("Последняя цифра введенного числа: " + result);
if(100 < number && number < 999)
{
    int result = number % 10;
    Console.WriteLine("Последняя цифра введенного числа: " + result);
}
else 
{
    Console.WriteLine("Число задано некорректно");

}
/* Вариант решения при совместном решении ДЗ

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (99 < a && a < 1000)
{
    int result = a % 10; 
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка");
}
*/
