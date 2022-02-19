// 75. Есть два массива info и data. 

// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. 
// Числа идут друг за другом без разделителей. 

// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.

// Составить массив десятичных представлений чисел массива data с учётом информации из массива info. 

// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1

// Какие ошибки могут возникнуть при обработке наборов данных?

Console.Clear();

void PrintArrayInt(int[] array)
{
	int count = array.Length;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

Console.WriteLine("Входные данные: ");
PrintArrayInt(data);
PrintArrayInt(info);

// переводим массив data  в string
string str = "";

foreach (int el in data)
{
	str += el.ToString();
}

// Создаем новый массив с результатом конвертации
int startIndex = 0;
int[] newData = new int[info.Length];

for (int i = 0; i < info.Length; i++)
{
	newData[i] = Convert.ToInt32((str.Substring(startIndex, info[i])), 2);
	startIndex = startIndex + info[i];
}

Console.WriteLine("Результат: ");
PrintArrayInt(newData);

