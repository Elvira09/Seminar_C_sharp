// Показать натуральные числа от M до N, N и M заданы

void showNaturalNumbers(int currentNumber, int number)
{
	if (currentNumber <= number) //если текущее число  меньше заданного числа
	{
		Console.Write($" {currentNumber}  "); 
		showNaturalNumbers(currentNumber + 1, number);
	}
}

Console.WriteLine("Введите первое число:  "); 
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:  "); 
int N = Convert.ToInt32(Console.ReadLine());
showNaturalNumbers(M, N);

