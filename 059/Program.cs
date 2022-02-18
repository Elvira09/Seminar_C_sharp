//    В прямоугольной матрице найти строку с наименьшей суммой элементов. 


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

void PrintArray(int[] array)
{
	int count = array.Length;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

int MinArray(int[] array)
{
	int min = array[0];
	int temp = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < min)
		{
			min = array[i];
			temp = i;
		}
	}
	return temp;
}

int stringTowDArray = 4;
int columnTowDArray = 6;
int[,] twoDArray = new int[stringTowDArray, columnTowDArray];
FillTowDArray(twoDArray);
Console.WriteLine($"Дан массив: ");


int[] tempArray = new int[stringTowDArray];
for (int i = 0; i < twoDArray.GetLength(0); i++)
{
	for (int j = 0; j < twoDArray.GetLength(1); j++)
	{
		tempArray[i] += twoDArray[i, j];
	}
}

PrintTowDArray(twoDArray);
Console.WriteLine("Суммы построчно ");
PrintArray(tempArray);
Console.WriteLine($"Cтрока с наименьшей суммой элементов под индексом {MinArray(tempArray)}");








// void FillArray(int[,] array, int columnLength, int lineLength)
// {
//     for (int i = 0; i < columnLength; i++)
//     {
//         for (int j = 0; j < lineLength; j++)
//         {
//             array[i, j] = new Random().Next(-10, 10);
//         }
//     }
// }

// void SumArray(int[,] array, int columnLength, int lineLength)
// {
//     int minIndex = 0;
//     int minSumArr = 0;
//     for (int k = 0; k < lineLength; k++)
//     {
//         minSumArr += array[0,k];
//     }
//     System.Console.WriteLine($"Sum line 0 is {minSumArr}");
//     for (int i = 1; i < columnLength; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < lineLength; j++)
//         {
//             sum += array[i, j];
//         }
//         System.Console.WriteLine($"Sum line {i} is {sum}");
//         if (minSumArr > sum)
//         {
//             minSumArr = sum;
//             minIndex = i;
//         }
//     }
//     System.Console.WriteLine($"{minIndex} line with the smallest sum of elements");
// }


// System.Console.Write("Enter