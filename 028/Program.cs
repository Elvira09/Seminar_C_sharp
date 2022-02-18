// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (0 < number)
{
	sum = sum + number % 10;
	number = number / 10;
}
	Console.WriteLine($"Сумма цифр в числе : {sum}");



