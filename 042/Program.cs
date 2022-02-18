// / Определить сколько чисел больше 0 введено с клавиатуры

// Вариант 1
Console.WriteLine("Введите числа через пробел");
string line = Console.ReadLine();

string[] lineArray = line.Split(" ");

int counter = 0;
for (int i = 0; i < lineArray.Length; i++)
{
    bool result = double.TryParse(lineArray[i], out double number); // ввели переменную для проверки а число ли перед нами
    if (result == false)
    {
        Console.WriteLine("введено не число");    
    }
    else
    {
        if (number>0)
        {
             counter++;
        }      
    }
}
Console.WriteLine($"Вы ввели {counter} чисел больше 0.");

// вариант 2
// Альтернативное решение 42
string line1;
int countPositive = 0;
Console.WriteLine("Введите числа, для завершения введите quit");
 while (true)
{
    line1 = Console.ReadLine();
    if (int.TryParse(line1, out int number))
    {
        if (number > 0) countPositive++;
    }
    else
    {
        if (line1 == "quit") break;
        Console.WriteLine("введено не число");
    }
}
Console.WriteLine(countPositive);

