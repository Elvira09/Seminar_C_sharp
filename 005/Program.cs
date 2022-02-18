// Написать программу вычисления значения функции y = f(a), а точнее f(a) = (1+1/a)^a

Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
double funct = 0;
if (number == 0)
{
	Console.WriteLine("Введенное число не корректно");
}
else
{
	funct = Math.Pow((1 + 1 / number), number);
	Console.WriteLine($"Функция (1+1/{number})^{number} равна {funct}");
}


