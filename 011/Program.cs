// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//int number = new Random().Next(10, 100);
System.Console.WriteLine("Введите число в диапозоне от 10 до 99");
int number = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(number);

int a = number % 10;
int b = number/ 10;
if (a > b)
{
    Console.WriteLine($"Наибольшая цифра числа {a}");
}
else
{
    Console.WriteLine(b);
}
