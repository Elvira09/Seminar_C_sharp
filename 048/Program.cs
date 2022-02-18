// Показать двумерный массив размером m×n заполненный целыми числами


Console.WriteLine("Введите количество строк массива ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int N = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[M, N];
for (int i = 0; i < M; i++)
{
	for (int j = 0; j < N; j++)
	{
		array[i, j] = new Random().Next();
		Console.Write($"[{i}][{j}]: {array[i,j]} \t"); 
	}
		Console.WriteLine(); //пропускаем строку
}



