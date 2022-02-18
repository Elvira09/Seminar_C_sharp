// Показать натуральные числа от 1 до N, N задано



void ShowNaturalNumbers(int currentNumber, int number)
{
	if (currentNumber <= number) //если текущее число  меньше заданного числа
	{
		Console.Write($" {currentNumber}  "); 
		ShowNaturalNumbers(currentNumber + 1, number);
	}
}

Console.WriteLine("Введите число:  "); 
int number = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbers(1, number);

