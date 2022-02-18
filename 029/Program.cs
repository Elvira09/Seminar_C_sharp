// 29. Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= number; i++)
{
	factorial = factorial * i;
}
Console.WriteLine($"Произведение чисел от 1 до {number} равна {factorial}");