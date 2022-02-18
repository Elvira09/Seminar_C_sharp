// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет


void PrintTowDArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			Console.Write($"[{i} {j}] {matr[i, j]} \t");
		}
		Console.WriteLine();
	}
}

void FillTowDArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i, j] = new Random().Next(0, 10);
		}
	}
}


void FindNumberTwoDArray(int[,] matr, int number)
{
	int indexI = 0;
	int indexJ = 0;
	bool examination = false;
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			if (matr[i, j] == number)
			{
				indexI = i;
				indexJ = j;
				examination = true;
				Console.WriteLine($"Введенное число на позиции [{indexI} {indexJ}]");
			}
		}
	}
	if (!examination) Console.WriteLine($"Введенное число не найдено");
}


Console.WriteLine("Введите количество строк массива ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int N = Convert.ToInt32(Console.ReadLine());


int[,] twoDArray = new int[M, N];
FillTowDArray(twoDArray);
Console.WriteLine("Дан массив: ");
PrintTowDArray(twoDArray);

Console.WriteLine("Введите число для поиска ");
int find = Convert.ToInt32(Console.ReadLine());
FindNumberTwoDArray(twoDArray, find);

