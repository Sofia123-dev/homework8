// Задача 54
// void FillArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//     for (int j = 0; j < array.GetLength(1); j++)
//       array[i, j] = new Random().Next(1, 10);
// }

// int[,] SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int tmp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = tmp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write($"{array[i, j],3} \t");
//     Console.WriteLine();
//   }
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// SortArray(array);
// PrintArray(array);

// Задача 56
// void FillArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//     for (int j = 0; j < array.GetLength(1); j++)
//       array[i, j] = new Random().Next(1, 10);
// }

// void SumEl(int[,] array)
// {
//     int mnr = 0;
//     int mns = 0;
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         mnr += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
//         if (sum < mnr)
//         {
//             mnr = sum;
//             mns = i;
//         }
//         sum = 0;
//     }
//     Console.Write($"{mns + 1} строка");
// }

// void PrintArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//       Console.Write($"{array[i, j],3} \t");
//     Console.WriteLine();
//   }
// }

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// SumEl(array);

// Задача 60.
// void FillArray(int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//     for (int j = 0; j < array.GetLength(1); j++)
//         for (int k = 0; k < array.GetLength(2); k++)
//             array[i, j, k] = new Random().Next(10, 100);
// }

// void PrintArray(int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//         Console.Write($"{array[i, j, k], 3}({i},{j},{k})");
//         Console.WriteLine();
//         }
//     }
//   }
// }

// int[,,] array = new int[2, 2, 2];
// FillArray(array);
// PrintArray(array);


