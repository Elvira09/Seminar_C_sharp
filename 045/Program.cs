// // Показать числа Фибоначчи

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstNumber = 0;
int secondNumberPositiv = 1;
int secondNumberNegativ = 1;
int fibonacciPositiv = 0;
int fibonacciNegativ = 0;

Console.Write($"Ряд Фибоначчи для {number}:  ");

for (int i = 0; i < number; i++) //для положительных чисел
{
	fibonacciPositiv = secondNumberPositiv;
	Console.Write("{0}  ", fibonacciPositiv);
	fibonacciPositiv = firstNumber + secondNumberPositiv;
	firstNumber = secondNumberPositiv;
	secondNumberPositiv = fibonacciPositiv;
}

for (int i = number + 1; i <= 0; i++) //для отрицательных чисел
{
	fibonacciNegativ = secondNumberNegativ;
	Console.Write("{0}  ", fibonacciNegativ);
	fibonacciNegativ = firstNumber - secondNumberNegativ;
	firstNumber = secondNumberNegativ;
	secondNumberNegativ = fibonacciNegativ;
}


// Console.Write("Введите конец диапазона от 1 до : ");
// int end = int.Parse(Console.ReadLine());
// int j = 1;
// for (int i = 1; i <= end; i += j)
// {
// 	Console.Write("{0} ", i);
// 	j = i - j;
// }
// Console.ReadKey();
// return 0;

