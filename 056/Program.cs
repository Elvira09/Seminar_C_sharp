// Написать программу, которая обменивает элементы первой строки и последней строки

void FillTowDArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i, j] = new Random().Next(-100, 100);
		}
	}
}

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

void Exchange(int[,] matr)
{
	int i = 0;
	for (int j = 0; j < matr.GetLength(1); j++)
	{
		int temporary = matr[i, j];
		matr[i, j] = matr[matr.GetLength(0)-1, j];
		matr[matr.GetLength(0)-1, j] = temporary;
	}
}

int[,] array = new int [4, 6];
FillTowDArray(array);
Console.WriteLine("Дан массив ");
PrintTowDArray(array);
Exchange(array);
Console.WriteLine("Получился массив ");
PrintTowDArray(array);
