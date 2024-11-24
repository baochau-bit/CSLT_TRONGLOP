using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace THithu
{
    internal class lamthufunction
    {
        static void Main(string[] args)
        {
            EX_06();
        }
        static float timMax(float a, float b, float c)
        {
            float m = Math.Max(Math.Max(a, b), c);
            return m;
        }
        static void EX_01()
        {
            Console.WriteLine("Nhap so thu nhat: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai  ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu ba  ");
            float c = float.Parse(Console.ReadLine());
            float kq = timMax(a, b, c);
            Console.WriteLine($"So lon nhat {kq}");
        }
        static int giaiThua(int a)
        {
            if (a > 0)
            {
                int GT = 1; //khoi tao gia tri giai thua bd bang 1
                for (int i = 1; i <= a; i++)
                {
                    GT *= i;
                }
                return GT;   //phair co return

            }
            else if (a < 0)
            {
                Console.WriteLine("Bạn đã nhập số âm ");
            }
            return -1; // Giá trị đặc biệt để báo lỗi.

        }

        static void EX_02()
        {
            Console.WriteLine(" Moi ban nhap so nguyen  ");
            int b = int.Parse(Console.ReadLine());
            int kq = giaiThua(b);
            if (kq != -1)
            {
                Console.WriteLine($"Ket qua {b}! là {kq}");
            }
        }
        static bool checkPrime(int a)  //so nguyen to la so chia het cho 1 va chinh no 
        {
            if (a <= 1)
                return false;
            if (a > 1)
            {
                for (int i = 2; i < a; i++)    // Lặp từ 2 đến số nhỏ hơn a 
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;  //return true để ngoài vòng lặp for để tránh kết luận true liền khi chưa xét hết

        }
        static void EX_03()
        {
            Console.WriteLine("nhap mot so :");
            int so = int.Parse(Console.ReadLine());
            if (checkPrime(so))
            {
                Console.WriteLine($"{so} la prime ");

            }
            else
            {

                Console.WriteLine($"{so} ko la prime ");
            }
        }
        static void EX_04()
        {   //print all prime num <  a num 
            Console.Write("Nhap mot so nguyen duong ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Cac so prime nho hon {x} la : ");
            for (int i = 2; i < x; i++)
            {
                if (checkPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
            // the 1st N prime number 
            Console.WriteLine();
            Console.Write("Ban muon in ra bao nhieu so nguyen to dau tien? __");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"{n} so nguyen to dau tien la:  ");
            int count = 0;

            for (int i = 2; count < n; i++)
            {
                if (checkPrime(i)) ;
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }

        }
        static bool checkperfectnum(int a)
        {
            if (a <= 0)  // Số hoàn hảo phải là số nguyên dương
            {
                return false;
            }

            int sum = 0;
            // Loop to find all divisors of 'a' (excluding 'a' itself)
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)  // If 'i' is a divisor of 'a'
                {
                    sum += i;// Add 'i' to the sum
                }
            }

            return sum == a;//Return true if the sum of divisors equals 'a'
        }

        // Function to check a number and print all perfect numbers less than 1000
        static void EX_05()
        {
            // Check if the user input number is a perfect number
            Console.WriteLine("Nhập số ngẫu nhiên để kiểm tra:");
            int num = int.Parse(Console.ReadLine());

            if (checkperfectnum(num))
            {
                Console.WriteLine($"{num} là số hoàn hảo.");
            }
            else
            {
                Console.WriteLine($"{num} không phải là số hoàn hảo.");
            }

            // Print all perfect numbers less than 1000
            Console.WriteLine("Các số hoàn hảo nhỏ hơn 1000 là:");

            for (int x = 1; x < 1000; x++)
            {
                if (checkperfectnum(x))  // Check if the number is perfect
                {
                    Console.WriteLine(x);  // Print the perfect number
                }
            }
        }


        public static void EX_06()
        {
            Console.WriteLine(" moi nhap 1 cau: ");
            string s = Console.ReadLine();
            int count = 0;
            for (int i = 65; i <= 90; i++)  //65 là mã ASCII của chữ cái A. 90 là mã ASCII của chữ cái Z
            {
                if (s.ToUpper().Contains((char)i))  //s.ToUpper(): Chuyển chuỗi người dùng nhập thành chữ hoa để so sánh không phân biệt chữ hoa và thường.
                                                    //(char)i: Chuyển số ASCII i thành ký tự (ví dụ, 65 -> A, 66 -> B).
                {
                    count++;
                }
                if (count >= 26)  // (char)i: Chuyển số ASCII i thành ký tự (ví dụ, 65 -> A, 66 -> B).
                {
                    Console.WriteLine("ban vua nhap 1 chuoi pangram");
                }
                else
                {
                    Console.WriteLine("day ko phai la chuoi ");
                }
            }
        }
    }
}











