// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите  число котолое нужно возвести в степень: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень возведения: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA;
for (int i = 1; i < numberB; i++)
{
	result = result * numberA;
}
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result} ");