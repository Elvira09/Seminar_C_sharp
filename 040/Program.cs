// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


void PrintArray(double[] array)
{
    int count = array.Length; 
    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



Console.WriteLine($"Дан массив со следующими элементами : ");
double[] array = {9.45, 68.3, 2.13, 76.3};
PrintArray(array);

double minTemporary = 0;
double maxTemporary = 0;

for (int i = 0; i < array.Length - 1 ; i++) 
{
        int minPosition = i; 
        for (int j = i + 1; j < array.Length; j++)
        {
            int maxPosition = j; 
			if(array[j] < array[minPosition]) maxPosition = j;
            maxTemporary = array[j]; 
		}
		minTemporary = array[i]; 	
}
Console.WriteLine("Минимальный элемент массива: " + minTemporary);
Console.WriteLine("Максимальный элемент массива: " + maxTemporary);
double difference = maxTemporary - minTemporary;
Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет: {difference}");


