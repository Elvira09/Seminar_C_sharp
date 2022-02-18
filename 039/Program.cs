// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void PrintArray(int[] array)
{
    int count = array.Length; 
    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Дан массив со следующими элементами : ");  
int[] array = {34, 14, -5, 9, 7, 6};
PrintArray(array);

int product = 0;

for (int i = 0; i < (array.Length / 2); i++)
{	
	if (i < array.Length & (array.Length -1) != i)
    {
        product = array[i] * array[array.Length-1-i];
		Console.WriteLine($"Произведение пар чисел {array[i]} и {array[array.Length-1-i]} равно {product} " );
    }
}


