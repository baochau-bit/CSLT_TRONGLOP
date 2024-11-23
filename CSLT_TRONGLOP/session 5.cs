using System;
using System.Text;

namespace MatrixOperations
{
    class Program  //mảng 2 chiều. 
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số hàng của ma trận (N): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột của ma trận (M): ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = GenerateRandomMatrix(n, m);
            Console.WriteLine("Ma trận ngẫu nhiên:");
            PrintMatrix(matrix);

            Console.Write("Nhập chỉ số dòng hoặc cột bạn muốn in (i): ");
            int i = int.Parse(Console.ReadLine());

            PrintRow(matrix, i);
            PrintColumn(matrix, i);

            Console.WriteLine($"Giá trị lớn nhất trong ma trận: {FindMaxValue(matrix)}");
            Console.WriteLine($"Giá trị nhỏ nhất của dòng {i}: {FindMinValueRow(matrix, i)}");
            Console.WriteLine($"Giá trị nhỏ nhất của cột {i}: {FindMinValueColumn(matrix, i)}");

            Console.WriteLine("Ma trận chuyển vị:");
            PrintMatrix(TransposeMatrix(matrix));

            PrintMainDiagonal(matrix);
            PrintSecondaryDiagonal(matrix);
        }

        static int[,] GenerateRandomMatrix(int n, int m)
        {
            Random rand = new Random();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rand.Next(1, 101); // Tạo số ngẫu nhiên từ 1 đến 100
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void PrintRow(int[,] matrix, int i)
        {
            if (i >= 0 && i < matrix.GetLength(0))
            {
                Console.WriteLine($"Dòng {i}: ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Chỉ số dòng không hợp lệ!");
            }
        }

        static void PrintColumn(int[,] matrix, int i)
        {
            if (i >= 0 && i < matrix.GetLength(1))
            {
                Console.WriteLine($"Cột {i}: ");
                for (int j = 0; j < matrix.GetLength(0); j++)
                    Console.WriteLine(matrix[j, i]);
            }
            else
            {
                Console.WriteLine("Chỉ số cột không hợp lệ!");
            }
        }

        static int FindMaxValue(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int value in matrix)
                if (value > max)
                    max = value;
            return max;
        }

        static int FindMinValueRow(int[,] matrix, int row)
        {
            if (row < 0 || row >= matrix.GetLength(0))
                throw new ArgumentException("Chỉ số dòng không hợp lệ!");

            int min = matrix[row, 0];
            for (int j = 1; j < matrix.GetLength(1); j++)
                if (matrix[row, j] < min)
                    min = matrix[row, j];
            return min;
        }

        static int FindMinValueColumn(int[,] matrix, int col)
        {
            if (col < 0 || col >= matrix.GetLength(1))
                throw new ArgumentException("Chỉ số cột không hợp lệ!");

            int min = matrix[0, col];
            for (int i = 1; i < matrix.GetLength(0); i++)
                if (matrix[i, col] < min)
                    min = matrix[i, col];
            return min;
        }

        static int[,] TransposeMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[,] transposed = new int[m, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    transposed[j, i] = matrix[i, j];
            return transposed;
        }

        static void PrintMainDiagonal(int[,] matrix)
        {
            Console.WriteLine("Giá trị đường chéo chính:");
            for (int i = 0; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
                Console.Write(matrix[i, i] + "\t");
            Console.WriteLine();
        }

        static void PrintSecondaryDiagonal(int[,] matrix)
        {
            Console.WriteLine("Giá trị đường chéo phụ:");
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < Math.Min(n, m); i++)
                Console.Write(matrix[i, m - 1 - i] + "\t");
            Console.WriteLine();
        }
    }
}
