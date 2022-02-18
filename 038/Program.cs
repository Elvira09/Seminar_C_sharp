// Найти сумму чисел одномерного массива стоящих на нечетной позиции

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
     // индекс  0    1   2    3    4   5   6
	//  позиция 1    2    3   4    5    6   7
int[] array = {347, -34, 24, 789, 123, -5, 96};
PrintArray(array);

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i%2 == 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine("Cумму чисел массива, стоящих на нечетной позиции:  " + sum);
