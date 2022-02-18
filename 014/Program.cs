// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (100 > a )
{
    Console.WriteLine("ошибка"); 
}
else
{
    string y = Convert.ToString(a);
    Console.WriteLine($"Третья цифра числа {y[2]}");
}