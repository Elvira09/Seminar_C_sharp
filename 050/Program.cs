// В двумерном массиве n×k заменить четные элементы на противоположные

// Уточнить как понимать "четные элементы" - четные позиции? я заменила четные столбцы


void FillTowDArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i, j] = new Random().Next(-10, 10);
		}
	}
}

void PrintTowDArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			Console.Write($"[поз.{i+1} {j+1}] {matr[i, j]}\t");
		}
		Console.WriteLine();
	}
}

Console.WriteLine("Введите количество строк массива ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int K = Convert.ToInt32(Console.ReadLine());

int[,] twoDArray = new int[N, K];
FillTowDArray(twoDArray);
Console.WriteLine("Дан массив: ");
PrintTowDArray(twoDArray);

Console.WriteLine("Замена четных элементов на противоположные: ");

for (int i = 0; i < N; i++)
{
	for (int j = 0; j < K; j++)

	{
		if ((j-1)%2 == 0 )
		{
			twoDArray[i, j] = twoDArray[i, j] * (-1);
		}
		Console.Write($"[поз. {i+1} {j+1}] {twoDArray[i,j]}\t"); 
	}
	Console.WriteLine(); 
}