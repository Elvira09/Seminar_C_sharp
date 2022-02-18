//// Найти сумму элементов от M до N, N и M заданы

void showNaturalNumbers(long currentNumber, long number)
{
	if (currentNumber <= number) //если текущее число  меньше заданного числа
	{
		Console.Write($" {currentNumber}  ");
		showNaturalNumbers(currentNumber + 1, number);
	}
}

long SumOfElements(long number1, long number2)
{
	if (number1 == number2) 
	{
		return number1;
	}
	else 
	{
		return number1 + SumOfElements(number1 + 1, number2);
	}
}

Console.WriteLine("Введите первое число:  ");
long M = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
long N = Convert.ToInt64(Console.ReadLine());

showNaturalNumbers(M, N);
Console.WriteLine();
Console.WriteLine($"Сумма чисел от {M} до {N} составляет: {SumOfElements(M, N)}");


// long summ = (M + N) * (N - M + 1)/2;
// Console.WriteLine($"Сумма чисел от {M} до {N} составляет: {summ}");

