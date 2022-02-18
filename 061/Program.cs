// Найти произведение двух матриц


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


int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
	int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
	for (int i = 0; i < matrix1.GetLength(0); i++) //количество строк итоговой матрицы
	{
		for (int j = 0; j < matrix2.GetLength(1); j++) //количество столбцов итоговой матрицы
		{
			for (int k = 0; k < matrix1.GetLength(1); k++) //количество строк/столбцов, которые должна пройти матрица при подсчете
			{
				resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
			}
		}
	}
	return resultMatrix;
}


int[,] matrix1 = new int[3, 4];
int[,] matrix2 = new int[4, 3];
FillTowDArray(matrix1);
FillTowDArray(matrix2);

Console.WriteLine($"Матрица 1: ");
PrintTowDArray(matrix1);
Console.WriteLine($"Матрица 2: ");
PrintTowDArray(matrix2);

int[,] result = MatrixProduct(matrix1, matrix2);

Console.WriteLine($"Результативная матрица: ");
PrintTowDArray(result);