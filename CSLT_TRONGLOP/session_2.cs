
using System.Collections.Concurrent;
using System.Threading.Channels;

internal class session_2
{
    static void Main(string[] args)
    {
        //Question_01();
        //Question_02();
        // Question_03();
         // Question_04();
          // Question_05();
        Console.ReadKey();
    }
    public static void Question_01()
    {
        float x, y;
        Console.WriteLine("nhap vao gia tri cua x: ");
        x = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap vao gia tri cua y :");
        y = float.Parse(Console.ReadLine());

        float z1 = x + y;
        float z2 = x - y;
        float z3 = x * y;
        float z4 = x / y;
        float z5 = x % y;
        Console.WriteLine($"{x} + {y} = {z1}");
        Console.WriteLine($"{x} - {y} = {z1}");
        Console.Write("{0} * {1} = {2}", x, y, z1);
        Console.WriteLine($"{x} / {y} = {z1}");
        Console.WriteLine($"{x} % {y} = {z1}");
    }
    public static void Question_02()
    {
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y = {y}, x = {x}");
        }
    }
    public static void Question_03()
    {
        Console.WriteLine("nhap thoi gian (gio): ");
        float hours = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap thoi gian (phut): ");
        float minutes = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap thoi gian (giay): ");
        float seconds = float.Parse(Console.ReadLine());
        Console.WriteLine("nhap khoang cach (km): ");
        float distance = float.Parse(Console.ReadLine());
        float totalTimeinhours = hours + (minutes / 60f) + (seconds / 3600f); // tinh tong thoi gian

        float speedKmh = distance / totalTimeinhours;
        float speedMph = speedKmh * 0.621371f;
        Console.WriteLine($"Tốc độ = {speedKmh} km/h ");
        Console.WriteLine($"Tốc độ= {speedMph} miles/h");
    }
    public static void Question_04()
    {
        double Pi = 3.14d;
        Console.WriteLine("nhap vao ban kinh hinh cau: ");
        double bankinh = double.Parse(Console.ReadLine());
        double dientich = 4 * Pi * Math.Pow(bankinh, 2);
        double chuvi = (4 / 3) * Pi * Math.Pow(bankinh, 3);
        Console.WriteLine($"Dien tich hinh cau la: {dientich}");
        Console.WriteLine($"Chu vi hinh cau la: {chuvi}");
}
    public static void Question_05()
    {
        Console.Write("Nhập một ký tự: ");
        char inputChar = Console.ReadKey().KeyChar; // Đọc ký tự từ người dùng
        Console.WriteLine(); 

        if ("aeiouAEIOU".Contains(inputChar))
        {
            Console.WriteLine($"{inputChar} là nguyên âm.");
        }
        else if (char.IsDigit(inputChar))
        {
            Console.WriteLine($"{inputChar} là chữ số.");
        }
        else if (char.IsLetter(inputChar))
        {
            Console.WriteLine($"{inputChar} là ký tự chữ cái khác.");
        }
        else
        {
            Console.WriteLine($"{inputChar} là ký tự khác.");
        }
    }
  }

