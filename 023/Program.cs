//Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i*i < N; i++)
{
	Console.Write($"[{i}] = {i*2},\t");
	if (i % 5 == 0)
	{
		Console.WriteLine();
	}
}