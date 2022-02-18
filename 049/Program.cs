// Показать двумерный массив размером m×n заполненный вещественными числами

Console.WriteLine("Введите количество строк массива ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int N = Convert.ToInt32(Console.ReadLine());

double [,] twoDArray = new double[M, N];
for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < N; j++)
		{
			twoDArray[i, j] = new Random().NextDouble();
			Console.Write($"[{i}][{j}]: {twoDArray[i,j]: N2} \t"); 
		}
			Console.WriteLine(); //пропускаем строку
	}