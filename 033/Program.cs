// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива


void FillArray(int[] array)
{
	int length = array.Length;
	int index = 0;
	while (index < length)
	{
		array[index] = new Random().Next(0, 10);
		index++;
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

int[] array = new int[12];
FillArray(array);
Console.WriteLine($"Дан массив со следующими элементами в диапозоне от 0 до 9: ");
PrintArray(array);

int index = 0;
int sum = 0;

while (index <= 11)
{
	if (array[index] > 0)
	{
		int count = array[index];
		sum = sum + count;
	}
	index++;
}
Console.WriteLine($"Сумма положительных элементов массива равна: {sum} ");


// array.Sort();
// Console.WriteLine(array);

// array.Reverse();
// Console.WriteLine(array);