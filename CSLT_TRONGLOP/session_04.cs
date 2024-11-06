using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_TRONGLOP
{
    internal class session_04
    {
        static void Main()
        {
            //bước 1: nhập số phần tử của mảng từ người dùng 
            Console.Write("enter the number of items in array: ");
            int N = int.Parse(Console.ReadLine());
            //Khởi tạo mảng với số phần tử N 
            int[] array = new int[N];
            // Bước 2: nhập các giá trị cho từng phần tử trong mảng 
            for (int i = 0; i < N; i++)
            {
                Console.Write($"enter value for item: {i + 1} : ");
                array[i] = int.Parse(Console.ReadLine());
            }
            //Bước 3 : in mảng ban đầu lên màn hình 
            Console.WriteLine(" Mang da nhap:  ");
            PrintArray(array);
            //Hàm để in ra các phần tử của mảng lên màn hình 
            static void PrintArray(int[] array)
            {
                foreach (int item in array)
                {
                    Console.Write($"{item}   ");

                }
                Console.WriteLine();
            }
        }

    }
}