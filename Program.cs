// Задача 54

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

//         for (int i = 0; i < array.GetLength(0); i++) 
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++) 
//             {
//                 for (int k = j + 1; k < array.GetLength(1); k++) 
//                 {
//                     if (array[i, j] < array[i, k]) 
//                     {
//                         int temp = array[i, j]; 
//                         array[i, j] = array[i, k];
//                         array[i, k] = temp;
//                     }
//                 }
//             }
//         }
        
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// Задача 56

// class Program 
// {
//     static void Main() 
//     {
//         // Задаем двумерный массив
//         int[,] array = new int[,] {
//             { 1, 4, 7, 2 },
//             { 5, 9, 2, 3 },
//             { 8, 4, 2, 4 },
//             { 5, 2, 6, 7 }
//         };

//         // Инициализируем переменные для хранения минимальной суммы и номера строки
//         int minSum = int.MaxValue;
//         int minSumIndex = -1;

//         // Считаем сумму элементов в каждой строке и ищем номер строки с наименьшей суммой
//         for (int i = 0; i < array.GetLength(0); i++) 
//         {
//             int sum = 0;
//             for (int j = 0; j < array.GetLength(1); j++) 
//             {
//                 sum += array[i, j];
//             }

//             if (sum < minSum) 
//             {
//                 minSum = sum;
//                 minSumIndex = i;
//             }
//         }

//         // Выводим результат
//         Console.WriteLine("Наименьшая сумма элементов в строке: " + (minSumIndex + 1));
//     }
// }




// Задача 58

// class Program {
//     static void Main(string[] args) {
//         // Исходные матрицы
//         int[,] matrix1 = { { 2, 4 }, { 3, 2 } };
//         int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

//         // Размеры матриц
//         int m1 = matrix1.GetLength(0);
//         int n1 = matrix1.GetLength(1);
//         int m2 = matrix2.GetLength(0);
//         int n2 = matrix2.GetLength(1);

//         // Проверка совместимости матриц
//         if (n1 != m2) {
//             Console.WriteLine("Ошибка! Умножение матриц невозможно.");
//             Console.ReadLine();
//             return;
//         }

//         // Создание результирующей матрицы
//         int[,] result = new int[m1, n2];

//         // Вычисление произведения матриц
//         for (int i = 0; i < m1; i++) {
//             for (int j = 0; j < n2; j++) {
//                 for (int k = 0; k < n1; k++) {
//                     result[i, j] += matrix1[i, k] * matrix2[k, j];
//                 }
//             }
//         }

//         // Вывод результирующей матрицы
//         Console.WriteLine("Результирующая матрица:");
//         for (int i = 0; i < m1; i++) {
//             for (int j = 0; j < n2; j++) {
//                 Console.Write(result[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.ReadLine();
//     }
// }



// Задача 60
// int[,,] arr = new int[2, 2, 2];
// int num = 10;

// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         for (int k = 0; k < 2; k++)
//         {
//             arr[i, j, k] = num;
//             num++;

//             if (num == 100)
//             {
//                 num = 10;
//             }
//         }
//     }
// }

// for (int k = 0; k < 2; k++)
// {
//     Console.WriteLine("Slice " + k + ":");

//     for (int i = 0; i < 2; i++)
//     {
//         for (int j = 0; j < 2; j++)
//         {
//             Console.Write(arr[i, j, k] + "(" + i + "," + j + "," + k + ") ");
//         }

//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }



//Задача 62 

// int[,] arr = new int[4, 4];
// int num = 1;
// int rowStart = 0, colStart = 0, rowEnd = arr.GetLength(0) - 1, colEnd = arr.GetLength(1) - 1;

// while (rowStart <= rowEnd && colStart <= colEnd)
// {
//     // Заполнение верхней строки
//     for (int i = colStart; i <= colEnd; i++)
//     {
//         arr[rowStart, i] = num;
//         num++;
//     }

//     // Заполнение правого столбца
//     for (int i = rowStart + 1; i <= rowEnd; i++)
//     {
//         arr[i, colEnd] = num;
//         num++;
//     }

//     if (rowStart < rowEnd)
//     {
//         // Заполнение нижней строки
//         for (int i = colEnd - 1; i >= colStart; i--)
//         {
//             arr[rowEnd, i] = num;
//             num++;
//         }
//     }

//     if (colStart < colEnd)
//     {
//         // Заполнение левого столбца
//         for (int i = rowEnd - 1; i > rowStart; i--)
//         {
//             arr[i, colStart] = num;
//             num++;
//         }
//     }

//     // Переход к следующему квадрату
//     rowStart++;
//     colStart++;
//     rowEnd--;
//     colEnd--;
// }

// // Вывод массива в консоль
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j].ToString("D2") + " ");
//     }
//     Console.WriteLine();
// }



