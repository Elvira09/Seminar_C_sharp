// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран 
// выводя индексы соответствующего элемента


int GetNextRandomUnicNumber() //заполнение не повторяющимися двузначными числами
{
	int[] matrix = new int[89];
	int number = new Random().Next(10, 100);
	for (int i = 0; i < matrix.Length; i++)
	{
		if (matrix[i] == number) return GetNextRandomUnicNumber();
		else if (matrix[i] == 0)
		{
			matrix[i] = number;
			break;
		}
	}
	return number;
}

void Fill3DArray(int[,,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			for (int k = 0; k < matr.GetLength(2); k++)
			{
				matr[i, j, k] = GetNextRandomUnicNumber();
			}
		}
	}
}


void Print3DArray(int[,,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			for (int k = 0; k < matr.GetLength(2); k++)
			{
				Console.Write($"[{i} {j} {k}] {matr[i, j, k]} \t");
			}
		}
		Console.WriteLine();
	}
}

int[,,] array3D = new int[4, 3, 2];
Fill3DArray(array3D);
Print3DArray(array3D);

