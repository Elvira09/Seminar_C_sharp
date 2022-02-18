// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"

using static System.Console;

// Мой вариант
Console.WriteLine($"Мой вариант ");


void PrintTowDArray(double[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			Console.Write($"{matr[i, j]} \t");

		}
		Console.WriteLine();
	}
}

double Scaling(double k, double[,] matr)
{
	double result = 0;
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i, j] *= k;
			result = matr[i, j];
		}
	}
	return result;
}

double[,] coordinates = {
				{-1, 1},
				{-1, 5},
				{6, 5},
				{6, 5},
				};

Console.WriteLine($"Даны координаты: ");
PrintTowDArray(coordinates);
double k = 0.5;
Console.WriteLine($"При коэффициенте масштабирования {k} получились координаты: ");
Scaling(k, coordinates);
PrintTowDArray(coordinates);


// Вариант на примере лекции 6
Console.WriteLine($"Вариант на примере лекции 6 ");

Console.WriteLine("Даны координаты");
string text = "(-1,1) (-1,5) (6,5) (6,5)"
			.Replace("(", "")
			.Replace(")", "");
Console.WriteLine(text);

int k1 = 2;
var data = text.Split(" ")
			.Select(item => item.Split(',')) 
			.Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))  
			.Select(point => (point.x * k1, point.y * k1)) 
			.ToArray(); 

Console.WriteLine($"При коэффициенте масштабирования {k1} получились координаты: ");

for (int i = 0; i < data.Length; i++)
{
	Console.WriteLine(data[i]);
}




// // Вариант совместного решения ДЗ

// Console.WriteLine($"Вариант совместного решения ДЗ ");


// string MyInput(string msg)
// {
//     Write(msg);
//     return ReadLine() ?? string.Empty;
// }

// double[] StringConvert(string stringDouble, char[] splitChar, out bool sign)
// {
//     string[] tmp = stringDouble.Split(splitChar, StringSplitOptions.RemoveEmptyEntries);
//     double[] result = new double[tmp.Length];
//     bool flag = false;
//     double temp = 0;
//     for (int i = 0; i < tmp.Length; i++)
//     {
//         flag = double.TryParse(tmp[i], out temp);
//         if (!flag)
//         {
//             WriteLine($"Неверный ввод: {tmp[i]}");
//             sign = false;
//             return result;
//         }
//         result[i] = temp;
//     }
//     sign = true;
//     return result;
// }

// void ScalingCoordinates(double[] coordinates, double coefficient)
// {
//     for (int i = 0; i < coordinates.Length; i++)
//         coordinates[i] *= coefficient;
// }

// void PrintArray(double[] array)
// {
//     int k = 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Write($"{array[i]}\t");
//         if (k % 7 == 0)
//             WriteLine();
//         k++;
//     }
//     WriteLine();
// }

// char[] splitFormat = { ' ', ',', '(', ')', '-', '_' };
// Console.Clear();
// while (true)
// {
//     bool sign = true;
//     string answer = MyInput("Введите координаты: ");
//     if (answer.Length == 0)
//         break;
//     double[] coordinates = StringConvert(answer, splitFormat, out sign);
//     WriteLine(sign);
//     if (!sign)
//         continue;
//     Write("Введите коэффициент: ");
//     string coefficient = ReadLine() ?? string.Empty;
//     bool flag = double.TryParse(coefficient, out double coefficientScaling);
//     if (!flag)
//     {
//         WriteLine($"Неверный ввод коэффициента: {coefficient}");
//         continue;
//     }
//     WriteLine("Введены координаты");
//     PrintArray(coordinates);
//     ScalingCoordinates(coordinates, coefficientScaling);
//     WriteLine("Координаты после масштабирования");
//     PrintArray(coordinates);
// }