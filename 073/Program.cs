// Написать программу показывающие первые N чисел, для которых каждое следующее 
// равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем


Console.Clear();

// // Вариант 1 - цикл

int Summ(int firstNumber, int secondNumber, int element)
{
	for (int i = 1; i <= element; i++)
	{
		int sum = firstNumber;
		Console.Write("{0}  ", sum);
		sum = firstNumber + secondNumber;
		firstNumber = secondNumber;
		secondNumber = sum;
	}
	return firstNumber;
}
Console.WriteLine("без рекурсии");
Summ(4, 6, 7);
// // 4  6  10  16  26  42  68   // 7 элементов последовательности
// // 1  2   1   2   1   2   1

Console.WriteLine();

// // Вариант 2 - Рекурсия
Console.WriteLine("С рекурсией");

void SummRec(int firstNumber1, int secondNumber1, int count, int element1)
{
	if (count < element1)
	{
		int sum1 = firstNumber1 + secondNumber1;
		Console.Write("{0}  ", sum1);
		count++;
		SummRec(secondNumber1, sum1, count, element1);
	}
}

int firstNumber1 = 4;
int secondNumber1 = 6;
int element1 = 7;

Console.Write($"{firstNumber1} {secondNumber1} ");
SummRec(firstNumber1, secondNumber1, 2, element1);


// // Вариант 3 - Рекурсия версия Вячеслава Доброва - лучшеБ чем второй вариант

Console.WriteLine("С рекурсией - версия Вячеслава Доброва");

void ShowNumbers(int number1, int number2, int howmanytimes, bool firstTime)
{
    if(howmanytimes>1)
    {
        if(firstTime)
        {
            Console.Write($"{number1} {number2} ");
            firstTime=false;
            ShowNumbers(number2,number1+number2,howmanytimes-1,firstTime);
        }
        else
        {
            Console.Write($"{number2} ");
            ShowNumbers(number2,number1+number2,howmanytimes-1,firstTime);
        }
    }
}
Console.WriteLine("Введите число номер 1");
int usernumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число номер 2");
int usernumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сколько чисел показать?");
int userEnter = Convert.ToInt32(Console.ReadLine());
bool firstTime = true;
ShowNumbers(usernumber1,usernumber2,userEnter,firstTime);


// еще вариант
double Fibonacci(int number, int A, int B)
{
    if (number == 1 ) return A;
    else if (number == 2) return B;
    else return Fibonacci(number-1, A, B)+ Fibonacci(number -2, A, B);
}

Console.Write("Введите количество элементов последовательности: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите первый элемент последовательности: ");
int a = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите второй элемент последовательности: ");
int b = int.Parse(Console.ReadLine()??"0");
for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"f({i}) = {Fibonacci(i, a, b)} ");
    }