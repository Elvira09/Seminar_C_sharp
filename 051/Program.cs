// Задать двумерный массив следующим правилом: Aₘₙ = m+n

// не уверена, что правильно поняла задание. Складываются индексы?

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
			matr[i, j] = new Random().Next(0);
		}
	}
}

Console.WriteLine("Введите количество строк массива ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] twoDArray = new int[M, N];
FillTowDArray(twoDArray);
Console.WriteLine("Дан массив: ");
PrintTowDArray(twoDArray);

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        twoDArray[i, j] = i + j;
    }
}

Console.WriteLine("Получился массив: ");
PrintTowDArray(twoDArray);