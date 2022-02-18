// В матрице чисел найти сумму элементов главной диагонали


void FillTowDArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i, j] = new Random().Next(0, 5);
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

int[,] twoDArray = new int[4, 4];
FillTowDArray(twoDArray);
Console.WriteLine($"Дан массив: ");
PrintTowDArray(twoDArray);
int summ = 0;
int temp = 0;
for (int i = 0; i < twoDArray.GetLength(0); i++)
{
	for (int j = 0; j < twoDArray.GetLength(1); j++)
	{
		if (i == j)
		{
			temp = twoDArray[i, j];
			summ = summ + temp;
		}
	}
}
Console.WriteLine($"Cумма элементов главной диагонали : {summ} ");
