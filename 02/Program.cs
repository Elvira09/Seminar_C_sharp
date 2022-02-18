//создаем метод по заполнению массива
void GenerateArray(int [] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(1, array.Length);
	}
}

//создаем метод выводу массива на консоль
void ShowArray(int [] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(1, array.Length);
		Console.Write($" [{i}]: {array[i]},"); //вывод на консоль элемента с его индексом
	}
}


//Пример с использованием методов
int arrayLength = 10; //задали длину массива
int [] riceItem = new int[arrayLength]; //создали новый массив
GenerateArray(riceItem);//заполнили массив с помощью метода
ShowArray(riceItem);//вывели на консоль массив
