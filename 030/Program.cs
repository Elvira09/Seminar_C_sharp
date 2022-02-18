//Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные кубы чисел от 1 до {number}: ");
for (int i = 1; i <= number ; i++)
{
	int result = i * i * i;
	if (result % 2 == 0)
	{
	Console.WriteLine(result);
	}
}

