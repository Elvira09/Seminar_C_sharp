// Эта работа требуется для проверки ваших знаний и навыков по итогам первого этапа обучения 
// на программе разработчика. Мы должны полагать, что базовое знакомство прошло успешно.

// Задача алгоритмически не наиболее изучена, однако для полного выполнения проверочной 
// работы необходимо:

// Создать репозиторий на GitHub
// Нарисовать блок-схему алгоритма (можно использовать блок-схему основной содержательной 
// части, если выделить ее в отдельный метод)
// Снабдить репозиторий оформленным текстовым описанием решений (файл README.md)
// Написать программу, определяющую установленную шкалу
// Использование контрольного механизма в этой работе над рассмотрением проекта

// Задача : Написать программу, которая из массива формирует массивы чисел, формирует массив 
// из чисел, больших 8. Первоначальный массив можно ввести с формулой, либо сгенерировать 
// случайным образом. Не рекомендуется использовать коллекции, лучше всего собирать уникальные 
// коллекции.

// Примеры :

// [1, 2, 3, 4] -> []
// [1, 3, 14, 5, 7, 1, 23] -> [14, 23]
// [2, -4, 16] -> [16]
// [11, 9, 8, 15] -> [11, 9, 15]


// Метод по заполнению массива
void FillArray(int[] collection)
{
	for (int i = 0; i < collection.Length; i++)
	{
		collection[i] = new Random().Next(1, 20);
	}
}

// Метод по выводу на консоль массива

void PrintArray(int[] collection)
{
	for (int i = 0; i < collection.Length; i++)
	{
		Console.Write($"{collection[i]} ");
	}
	if (collection.Length == 0)
	{
		Console.WriteLine("Элементы массива отсутствуют");
		// return;
	}
	Console.WriteLine();
}

// Метод по поиску количества элементов больше 8
int SearchElements(int[] collection)
{
	int count = 0;
	for (int i = 0; i < collection.Length; i++)
	{

		if (collection[i] > 8)
		{
			count++;
		}
	}
	return count;
}

// // Метод по внесению найденных элементов в новый массив
// int ReplaceDigits(int[] collection, int[] newCollection)
// {
// 	int j = 0;

// 	for (int i = 0; i < collection.Length; i++)
// 	{
// 		if (collection[i] > 8)
// 		{
// 			newCollection[j] = collection[i];
// 		}
// 		j++;

// 	}
// 	return newCollection[j];
// }

int[] array = new int[15];
FillArray(array);
PrintArray(array);
// int[] newArray = new int [25];
// IndexOf(array);
// int count = SearchElements(array);
// int[] newArray = new int[SearchElements(array)];
int newArrayLength = SearchElements(array);
int[] newArray = new int[newArrayLength];


for (int i = 0; i < array.Length; i++)
{
	int newElement = array[i];
	// int strLength = strNew.Length;
	if (array[i] > 8)
	{
		newArray[i] = array[i];
	}
}

// ReplaceDigits(array, newArray);
PrintArray(newArray);



// int[] Array = new int[10];
// int[] NewArray = new int[10];

// void CreatPrintArray(int[] Array)
// {
//   for (int i = 0; i < Array.Length; i++)
//   {
//     Array[i] = new Random().Next(1, 15);
//     Console.Write($"{Array[i]} ");
//   }
// }

// void ChangeArray(int[] Array)
// {
//   for (int i = 0; i < Array.Length; i++)
//   {
//     NewArray[i] = Array[i];
//     if (NewArray[i] >8)
//       System.Console.Write($"{NewArray[i]} ");
//   }
// }


// CreatPrintArray(Array);
// System.Console.WriteLine();
// ChangeArray(Array);


