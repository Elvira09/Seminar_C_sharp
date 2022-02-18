// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).


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

int[,] ReplacingRowsColumnsTowDArray(int[,] matr)
{
	int[,] tempMatrix = new int[matr.GetLength(0), matr.GetLength(1)];
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			tempMatrix[j, i] = matr[i, j];
		}
	}
	return tempMatrix;
}


int[,] array = new int[4, 4];
FillTowDArray(array);
Console.WriteLine("Дан массив ");
PrintTowDArray(array);

if (array.GetLength(0) == array.GetLength(1))
{
	Console.WriteLine("Получился массив ");
	PrintTowDArray(ReplacingRowsColumnsTowDArray(array));
}
else Console.Write("Количество строк не соответствует количеству столбцов");
