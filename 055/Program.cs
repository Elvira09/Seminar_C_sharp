// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


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

void PrintArray(double[] array)
{
	int count = array.Length;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

int stringTowDArray = 4;
int columnTowDArray = 6;
int[,] twoDArray = new int[stringTowDArray, columnTowDArray];
FillTowDArray(twoDArray);
Console.WriteLine($"Дан массив: ");
PrintTowDArray(twoDArray);

Console.WriteLine("Суммы по столбцам ");
double[] tempArray = new double[columnTowDArray];
for (int i = 0; i < twoDArray.GetLength(0); i++)
{
	for (int j = 0; j < twoDArray.GetLength(1); j++)
	{
		tempArray[j] += twoDArray[i, j];
	}
}
PrintArray(tempArray);
Console.WriteLine("Cреднее арифметическое каждого из столбцов :");
foreach (double arithmeticMean in tempArray) //переменная 'arithmeticMean' которая будет содержать каждую переменную массива 'tempArray' 
{
	Console.Write(" " + arithmeticMean / stringTowDArray);
}
