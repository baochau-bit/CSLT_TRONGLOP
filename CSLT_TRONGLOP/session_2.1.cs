using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_TRONGLOP
{
    internal class session_2
    {
        private static void Main(string[] args)
        {
            //  Question_01();
          //Question_02();
          Question_03();
            // Question_04();
            // Question_05();
            Console.ReadKey();
        }
        public static void Question_01() // Write a C# Sharp program to check whether a given number is even or odd. 
        {
            int a;
            Console.WriteLine("nhap vao so a:  ");
            a = int.Parse(Console.ReadLine());
            int div = a % 2;
            switch (div)
            {
                case 0:
                    Console.WriteLine($"so a chan");
                    break;
                case 1:
                    Console.WriteLine($"so a le");
                    break;
            }
        }
        public static void Question_02() //Write a C# Sharp program to find the largest of three numbers
        {
            int num1, num2, num3;
            Console.WriteLine();
            Console.WriteLine("nhap num1 ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap num 2 ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap num3 ");
            num3 = int.Parse(Console.ReadLine());
            int largest;
            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
            }
            else
            {
                largest = num3;
            }
            Console.WriteLine($"so lon nhat la {largest}");
        }
        public static void Question_03()
        {
            Console.OutputEncoding = Encoding.UTF8;
            double x, y;

            
            Console.WriteLine("Nhập tọa độ X: ");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập tọa độ Y: ");
            y = double.Parse(Console.ReadLine());

          
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm trong phần tư I");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Điểm nằm trong phần tư II");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm trong phần tư III");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Điểm nằm trong phần tư IV");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Điểm nằm tại gốc tọa độ (0, 0)");
            }
            else if (x == 0)
            {
                Console.WriteLine("Điểm nằm trên trục Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Điểm nằm trên trục X");
            }
        }

    }
}
