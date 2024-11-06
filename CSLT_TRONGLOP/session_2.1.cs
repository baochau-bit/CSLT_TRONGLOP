using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSLT_TRONGLOP
{
    internal class session_2
    {
        private static void Main(String[] args)
        {
            //  Question_01();
            //Question_02();
            // Question_03();
            //   Question_04();
            //Question_05();
            // Question_06();
            //   Question_07();
            //Question_08();
            //   Question_09();
            // Question_10();
            Question_11();
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
        public static void Question_04() //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene. 
        {
            Console.WriteLine("nhap do dai 3 canh cua hinh tam giac: ");
            Console.Write("canh 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("canh 2 : ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("canh 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("canh khong hop le. do dai phai lon hon 0. ");
            }
            else
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("tam giac deu ");
                }
                else if (side1 == side2 || side2 == side3 || side3 == side1)
                {
                    Console.WriteLine("tam giac can");
                }
                else
                {
                    Console.WriteLine("tam giac thuong ");
                }
            }


        }
        public static void Question_05() //Write a program to read 10 numbers and find their average and sum.
        {
            int sum = 0; // khoi tao  sum la 0 
            int count = 10;
            Console.WriteLine("Nhap vao cac so tu 1-10: ");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"so {i + 1} :");
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            double average = (double)sum / count;
            Console.WriteLine("Tog của 10 số là: " + sum);
            Console.WriteLine("trung binh 10 so la " + average);
        }

        public static void Question_06() //Write a program to display the multiplication table of a given integer
        {
            Console.WriteLine("nhap vao 1 so nguyen bat ky: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                int ketqua = number * i;
                Console.WriteLine($"{number} * {i} ={ketqua} ");
            }

        }
        public static void Question_07() //Write a program to display a pattern like triangles with a number (type 1) 
        {
            Console.Write("Nhap vao so dong cua tam giac: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}  ");
                }
                Console.WriteLine();  // xuong dong sau moi dong 
            }
        }
        public static void Question_08()  //Write a program to display a pattern like triangles with a number(type 2) 
        {
            Console.WriteLine("nhap so dong cua tam giac: ");
            int rows = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{number}  ");
                    number++;
                }
                Console.WriteLine();
            }

        }
        public static void Question_09() //Write a program to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms 
        {
            Console.Write("Enter the number of terms (n): ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;

            Console.Write("Harmonic series: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0}", i);
                if (i < n)
                {
                    Console.Write(" + ");
                }
                sum += 1.0 / i;
            }

            Console.WriteLine("\nSum of harmonic series up to {0} terms: {1}", n, sum);
        }
        public static void Question_10()
        {
            Console.Write("Nhập vào số bắt đầu của khoảng: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhập vào số kết thúc của khoảng: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("Các số hoàn hảo trong khoảng từ {0} đến {1} là:", start, end);

            for (int number = start; number <= end; number++)
            {
                int sum = 0;

                for (int i = 1; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == number && number != 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
        public static void Question_11()  //Write a program to determine whether a given number is prime or not
        {
            Console.Write("Nhập một số: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine("{0} là số nguyên tố.", number);
            }
            else
            {
                Console.WriteLine("{0} không phải là số nguyên tố.", number);
            }
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false; 
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; 
                }
            }

            return true;
        }
    }
}

      
            
        
       
    


