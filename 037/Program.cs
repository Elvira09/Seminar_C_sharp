// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] array) 
{
    int length = array.Length; 
    int index = 0; 
    while (index < length) 
    {
        array[index] = new Random().Next(-200, 200); 
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

int[] array = new int[123];
FillArray(array);
Console.WriteLine($"Дан массив со следующими элементами : ");
PrintArray(array);

int counter = 0;

for (int i = 0; i < array.Length; i++)
{
    if (10 <= array[i] & array[i] <= 99)
    {
		counter ++;
    }
}
Console.WriteLine("Количество элементов в массиве в диапозоне [10, 99]:  " + counter);

