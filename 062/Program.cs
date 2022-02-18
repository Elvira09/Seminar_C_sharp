// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


void FillTowDArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i, j] = new Random().Next(0, 10);
		}
	}
}

void PrintTowDArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			Console.Write($"[{i} {j}] {matr[i, j]} \t");
		}
		Console.WriteLine();
	}
}

(int, int) MinTowDArray(int[,] matr)
{
	int min = matr[0, 0];
	int temp = 0;
    int minI = 0;
    int minJ = 0;
	for (int i = 0; i < matr.GetLength(0); i++)
	{
        
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			if (matr[i, j] < min)
			{
                minI = i;
                minJ = j;
				min = matr[i, j];
				temp = matr[i, j];
			}
		}
	}
	return (minI, minJ);
}

int[,] NewArray(int[,] matrix) // удаление строки и столбца
{
    int[,] newMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    int count1 = 0;
    (int indexI, int indexJ) = MinTowDArray(matrix);
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if(indexI == i) continue;
        
        int count2 = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(indexJ == j) continue;
            newMatrix[count1, count2] = matrix[i, j];
            count2++;
        }
        count1++;
    }
return newMatrix;
}

int[,] array = new int [4,4];

FillTowDArray(array);
PrintTowDArray(array);
Console.WriteLine(MinTowDArray(array));
int[,] newAr = NewArray(array);
PrintTowDArray(newAr);
























// // int[] matrix = new int[89];
// // int GetNextRandomUnicNumber()
// // {
// // 	int number = new Random().Next(10, 100);
// // 	for (int i = 0; i < matrix.Length; i++)
// // 	{
// // 		if (matrix[i] == number)
// // 		{
// // 			return GetNextRandomUnicNumber();
// // 		}
// // 		else if (matrix[i] == 0)
// // 		{
// // 			matrix[i] = number;
// // 			break;
// // 		}
// // 	}
// // 	return number;
// // }

// // void FillTowDArray(int[,] matr)
// // {
// // 	for (int i = 0; i < matr.GetLength(0); i++)
// // 	{
// // 		for (int j = 0; j < matr.GetLength(1); j++)
// // 		{
// // 			matr[i, j] = GetNextRandomUnicNumber();
// // 		}
// // 	}
// // }

// // void PrintTowDArray(int[,] matr)
// // {
// // 	for (int i = 0; i < matr.GetLength(0); i++)
// // 	{
// // 		for (int j = 0; j < matr.GetLength(1); j++)
// // 		{
// // 			Console.Write($"[{i} {j}] {matr[i, j]} \t");
// // 		}
// // 		Console.WriteLine();
// // 	}
// // }

// // int MinTowDArray(int[,] matr)
// // {
// // 	int min = matr[0, 0];
// // 	int temp = 0;
// // 	for (int i = 0; i < matr.GetLength(0); i++)
// // 	{
// // 		for (int j = 0; j < matr.GetLength(1); j++)
// // 		{
// // 			if (matr[i, j] < min)
// // 			{
// // 				min = matr[i, j];
// // 				temp = matr[i, j];
// // 			}
// // 		}
// // 	}
// // 	return temp;
// // }

// // int[,] twoDArray = new int[4, 5];
// // FillTowDArray(twoDArray);
// // Console.WriteLine("Дан массив ");
// // PrintTowDArray(twoDArray);

// // int minElement = MinTowDArray(twoDArray);
// // Console.WriteLine($"Минимальный элемент {minElement}");

// // int minIndexI = 0;
// // int minIndexJ = 0;
// // int IndexI = 0;
// // int IndexJ = 0;

// // for (int i = 0; i < twoDArray.GetLength(0); i++)
// // {
// // 	for (int j = 0; j < twoDArray.GetLength(1); j++)
// // 	{
// // 		if (twoDArray[i, j] == minElement)
// // 		{
// // 			minIndexI = i;
// // 			minIndexJ = j;
// // 		}
// // 	}
// // }

// // int[,] newTwoDArray = new int[twoDArray.GetLength(0) - 1, twoDArray.GetLength(1) - 1];

// // for (int i = 0; i < twoDArray.GetLength(0)-1; i++)
// // {
// // 	for (int j = 0; j < twoDArray.GetLength(1)-1; j++)
// // 	{
// // 		if (i != minIndexI && j != minIndexJ)
// // 		{
			
			
// // 			twoDArray[i, j] = true;

// // 			// if(i != minIndexI && j != minIndexJ)
// // 			// {
// // 				// IndexI = i;
// // 				// IndexJ = j;
// // 				// newTwoDArray[i, j] = newTwoDArray[IndexI, IndexJ];
// // 			// }
// // 		}
// // 	}
// // }


// // Console.WriteLine("twoDArray ");

// // PrintTowDArray(twoDArray);

// // Console.WriteLine("newTwoDArray ");

// // PrintTowDArray(newTwoDArray);




// const int N = 10, M = 12;
 
// // using namespace std;
 
// int main()
// {
//     std::srand((unsigned)std::time(nullptr));
 
//     int** matrix = new int*[N];
//     memset((void*)&matrix[0], 0x00, 4 * N);
 
//     for (int i = 0; i < N; i++)
//     {
//         matrix[i] = new int[M];
//         for (int j = 0; j < M; j++)
//         {
//             matrix[i][j] = std::rand() % (N - 1) + 1;
//             std::cout << matrix[i][j] << " ";
//         }
 
//         std::cout << endl;
//     }
 
//     std::cout << endl;
 
//     int max_i = 0, max_j = 0;
//     for (int i = 0; i < N; i++)
//         for (int j = 0; j < M; j++)
//             if (matrix[i][j] > matrix[max_i][max_j])
//             {
//                 max_i = i; max_j = j;
//             }
 
//     std::cout << "matrix[" << max_i << "][" << max_j << "] = " << matrix[max_i][max_j] << endl;
 
//     for (int i = 0; i < N; i++)
//     {
//         for (int j = max_j; j < M - 1; j++)
//             matrix[i][j] = matrix[i][j + 1];
//     }
 
//     for (int i = max_i; i < N - 1; i++)
//         matrix[i] = matrix[i + 1];
 
//     for (int i = 0; i < N - 1; i++)
//     {
//         for (int j = 0; j < M - 1; j++)
//             std::cout << matrix[i][j] << " ";
 
//         std::cout << endl;
//     }
 
//     std::cin.get();
//     std::cin.get();
 
//     return 0;
// }