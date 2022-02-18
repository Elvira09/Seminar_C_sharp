// Показать натуральные числа от N до 1, N задано


void showNumbers(int number)
{
	if (1 <= number) 
	{
		Console.Write($" {number}  "); 
		showNumbers(number - 1);
	}
}

// Вариант 1

Console.WriteLine("Введите число:  "); 
int number = Convert.ToInt32(Console.ReadLine());
showNumbers(number);
		

// Вариант 2 с проверкой корректности ввода числа
while (true)
{
	Console.WriteLine("Введите число:  "); 
	int number2 = Convert.ToInt32(Console.ReadLine());
	 if (number2 > 0) //проверяем корректность ввода числа
	 {
		showNumbers(number2);
		break;
	 }
	 else
	 {
		 Console.WriteLine("Некорректно введено число, введите число больше 1:  "); 
	 }
}



