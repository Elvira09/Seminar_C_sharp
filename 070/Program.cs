// Найти сумму цифр числа

// Вариант 1 - цикл

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (0 < number)
{
	sum = sum + number % 10;
	number = number / 10;
}
Console.WriteLine($"С помощью цикла: Сумма цифр в числе -  {sum}");

// Вариант 2 - рекурсия 

int SumOfDigits(int number)
{
	if (number < 10) 
	{
		return number;
	}
	int sum = number % 10 + SumOfDigits(number / 10);
	return sum;
}

Console.WriteLine("Введите число : ");
int number1 = Convert.ToInt32(Console.ReadLine());
int sum1 = SumOfDigits(number1);
Console.WriteLine($"С помощью рекрсии: Сумма цифр в числе - {sum1}");
