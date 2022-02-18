// // Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника

// Треугольник Паскаля – это числовая бесконечная таблица, в которой по краям стоят единицы, 
// а каждое число внутри равно двум стоящим над ним в ближайшей строке сверху

// Формула с использованием факториала : n! / (k! * (n-k)!) ,
// где n - номер строки треугольника, а k — номер числа в строке 
// (нумерация начинается в обоих случаях с нуля)



// // с использованием рекурсии - НЕ РАБОТАЕТ!!!
int Factorial(int number) 
{
	// 1! = 1 факториал 1 равен 1
	// 0! = 1 факториал 0 равен 1
	if (number == 0 || number == 1) 
	{
		return 1;
	}
	else 
	{
		return number * Factorial(number - 1);
	}
}
// // Console.WriteLine(Factorial(8));


// int Factorial(int number)
// {
// 	int result = 1;
// 	for (int i = 1; i <= number; i++)
// 	{
// 		result *= i;
// 	}
// 	return result;
// }
// // Console.WriteLine(Factorial(8));


Console.WriteLine("Введите количество строк треугольника Паскаля:");
int number = Convert.ToInt32(Console.ReadLine());

for (int count = 0; count < number; count++)
{
	// ГУГЛ В ПОМОЩЬ - 'number - count' создаём после каждой строки  отступы от левой стороны консоли, 
	// чем ниже строка, тем меньше отступ
	for (int k = 0; k <= (number - count); k++) 
	{
		Console.Write(" ");
	}
	
	for (int k = 0; k <= count; k++)
	{
		Console.Write($" {Factorial(count) / (Factorial(k) * Factorial(count - k))}"); 
	}
	Console.WriteLine(); 
}

