// Метод по поиску количества элементов массива длина которых меньше либо ранво 3 символам
int SearchItems(string[] collection)
{
	int count = 0;
	for (int i = 0; i < collection.Length; i++)
	{
		string strTemp = collection[i];
		int length = strTemp.Length;
		if (length <= 3)
		{
			count++;
		}
	}
	return count;
}

// Метод вывода одномерного массива на консоль
void PrintArray(string[] collection)
{
	for (int i = 0; i < collection.Length; i++)
	{
		Console.Write($"{collection[i]} \t");
	}
	Console.WriteLine();
}

// Метод по созданию нового массива, заполнение его отобранными элементами и вывод на консоль
void FillArraySelectedItems(string[] collection)
{
	string[] newCollection = new string[collection.Length];
	
	for (int i = 0; i < collection.Length; i++)
	{
		string strNew = collection[i];
		int j = SearchItems(collection) - 1;
		if (strNew.Length <= 3)
		{
			newCollection[j] = collection[i];
			Console.Write($"{newCollection[j]} \t");
		}
	}
	Console.WriteLine();
}

// Создаем первоначальный массив
string[] array = { "hello", "25", "Russia", "-2", "world", ":-", "dog", "cat", "1345", "array", "947" };

// Выводим первоначальный масссив на консоль
Console.WriteLine($"Дан массив: ");
PrintArray(array);

// Выводим на консоль новый итоговый массив с отобранными элементами
Console.WriteLine($"Итоговый массив: ");
FillArraySelectedItems(array);

