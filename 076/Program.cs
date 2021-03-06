// // Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.
// // Например для N = 50, M получается 6
// // Одно из решений :
// // Группа 1: 1 
// // Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
// // Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
// // Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
// // Группа 5: 7 16 24 36 40 
// // Группа 6: 5 32 48

// // Задача: найти M при заданном N и получить одно из разбиений на группы N ≤ 10²⁰

// // ПРОРАБОТАТЬ!!!! - ниже вариант от Вячеслава Доброва

// using System.Text;

// long GetNumber()
// {
//     Console.WriteLine("Введите число N: ");
//     long number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// int GetSizeSimpleNumbers(long number)
// {
//     long i = 3;
//     int result = 2;
//     while (i <= number)
//     {
//         bool check = true;
//         long s = 2;
//         for (s = 2; i / 2 >= s && check == true; s++)
//         {
//             if (i % s == 0)
//             {
//                 check = false;
//             }
//         }
//         if (check == true && s != 2) result++;
//         i++;
//     }
//     return result;
// }
// void FillSimpleNumbers(List<long> listSimpleNumbers, long number)
// {
//     listSimpleNumbers.Add(2);
//     listSimpleNumbers.Add(3);
//     long i = 3;
//     while (i <= number)
//     {
//         bool check = true;
//         long s = 2;
//         for (s = 2; i / 2 >= s && check == true; s++)
//         {
//             if (i % s == 0)
//             {
//                 check = false;
//             }
//         }
//         if (check == true && s != 2)
//         {
//             listSimpleNumbers.Add(i);
//         }
//         i++;
//     }
// }
// void ShowLine(long[] Array)
// {
//     StringBuilder str = new StringBuilder();
//     str.Append("2 группа: ");
//     for (int i = 0; i < Array.Length; i++)
//     {
//         str.Append($"{Array[i]} ");
//     }
//     Console.WriteLine(str.ToString());
// }
// int NumberGroups(long number)
// {
//     int k = 1;
//     while (Math.Pow(2, k) <= number)
//     {
//         k++;
//     }
//     Console.WriteLine($"Количество групп - {k}");
//     return k;
// }
// void CreatingGroups(long[] Array, long number, int M)
// {
//     int k = 1;
//     while (k < M - 1)
//     {
//         StringBuilder str = new StringBuilder();
//         str.Append($"{k + 2} группа: ");
//         for (int i = 0; i < Array.Length && Math.Pow(i, k + 1) < number; i++)
//         {
//             for (int j = i; j < Array.Length && j < number / j; j++)
//             {
//                 long current = (long)Math.Pow(Array[i]+0.0, k) * Array[j];
//                 if (current <= number)
//                 {
//                     str.Append($"{current} ");
//                 }
//             }
//         }
//         //Console.WriteLine(str.ToString());
//         k++;
//     }
// }
// long UserNumber = GetNumber();
// int numberGroups = NumberGroups(UserNumber);
// //int size = GetSizeSimpleNumbers(UserNumber);
// List<long> ListSimpleNumbers = new List<long>();
// FillSimpleNumbers(ListSimpleNumbers,UserNumber);
// Console.WriteLine("1 группа: 1");
// ShowLine(ListSimpleNumbers.ToArray());
// CreatingGroups(ListSimpleNumbers.ToArray(), UserNumber, numberGroups);


/*
Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.
Например для N = 50, M получается 6

Одно из решений :

Группа 1: 1 
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 7 16 24 36 40 
Группа 6: 5 32 48
Задача: найти M при заданном N и получить одно из разбиений на группы N ≤ 10²⁰*/

using System.Text;

long GetNumber()
{
	Console.WriteLine("Введите число N: ");
	long number = Convert.ToInt32(Console.ReadLine());
	return number;
}

int GetSizeSimpleNumbers(long number)
{
	long i = 3;
	int result = 2;
	while (i <= number)
	{
		bool check = true;
		long s = 2;
		for (s = 2; i / 2 >= s && check == true; s++)
		{
			if (i % s == 0)
			{
				check = false;
			}
		}
		if (check == true && s != 2) result++;
		i++;
	}
	return result;
}

void FillSimpleNumbers(List<long> listSimpleNumbers, long number)
{
	listSimpleNumbers.Add(2);
	listSimpleNumbers.Add(3);
	long i = 3;
	while (i <= number)
	{
		bool check = true;
		long s = 2;
		for (s = 2; i / 2 >= s && check == true; s++)
		{
			if (i % s == 0)
			{
				check = false;
			}
		}
		if (check == true && s != 2)
		{
			listSimpleNumbers.Add(i);
		}
		i++;
	}
}

void ShowLine(long[] Array)
{
	StringBuilder str = new StringBuilder();
	str.Append("2 группа: ");
	for (int i = 0; i < Array.Length; i++)
	{
		str.Append($"{Array[i]} ");
	}
	Console.WriteLine(str.ToString());
}

int NumberGroups(long number)
{
	int k = 1;
	while (Math.Pow(2, k) <= number)
	{
		k++;
	}
	Console.WriteLine($"Количество групп - {k}");
	return k;
}

void CreatingGroups(long[] Array, long number, int M)
{
	int k = 1;
	while (k < M - 1)
	{
		StringBuilder str = new StringBuilder();
		str.Append($"{k + 2} группа: ");
		for (int i = 0; i < Array.Length && Math.Pow(i, k + 1) < number; i++)
		{
			for (int j = i; j < Array.Length && j < number / j; j++)
			{
				long current = (long)Math.Pow(Array[i] + 0.0, k) * Array[j];
				if (current <= number)
				{
					str.Append($"{current} ");
				}
			}
		}
		//Console.WriteLine(str.ToString());
		k++;
	}
}
long UserNumber = GetNumber();
int numberGroups = NumberGroups(UserNumber);
//int size = GetSizeSimpleNumbers(UserNumber);
List<long> ListSimpleNumbers = new List<long>();
FillSimpleNumbers(ListSimpleNumbers, UserNumber);
Console.WriteLine("1 группа: 1");
ShowLine(ListSimpleNumbers.ToArray());
CreatingGroups(ListSimpleNumbers.ToArray(), UserNumber, numberGroups);