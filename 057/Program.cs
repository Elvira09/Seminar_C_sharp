// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


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

int SelectionSortLineTowDArray(int[,] matr)
{
	int temporary = 0;
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		// int minPosition = i;
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			for (int k = 0; k < matr.GetLength(1) - 1 - j; k++)
			{
				if (matr[i, k] < matr[i, k + 1])
				{
					temporary = matr[i, k];
					matr[i, k] = matr[i, k + 1];
					matr[i, k + 1] = temporary;
				}
			}
		}
	}
	return temporary;
}


int[,] array = new int[3, 4];
FillTowDArray(array);
Console.WriteLine("Дан массив ");
PrintTowDArray(array);
SelectionSortLineTowDArray(array);
Console.WriteLine("Получился массив ");
PrintTowDArray(array);


