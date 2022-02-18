//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


void FillArray(int[] array) 
{
    int length = array.Length; 
    int index = 0; 
    while (index < length) 
    {
        array[index] = new Random().Next(100, 999); 
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

int[] array = new int[8];
FillArray(array);
Console.WriteLine($"Дан массив со следующими элементами : ");
PrintArray(array);

int evenCounter = 0;
int oddCounter = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 == 0)
    {
        evenCounter ++;
    }
    else
    {
        oddCounter ++;
    }
}
Console.WriteLine("Количество четных чисел в массиве:  " + evenCounter);
Console.WriteLine("Количество нечетных чисел в массиве:  " + oddCounter);

