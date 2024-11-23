internal class program
{
    public static float sum(float a, int b)
    {
        return a + b;
    }
    public static void tinhtong()
    {
        Console.WriteLine("Get go!");
        //int x = int.Parse(Console.ReadLine());
        //int y = int.Parse(Console.ReadLine());
        float x = 6;
        int y = 5;
        float tong = sum(x, y);
        Console.WriteLine(tong);
    }
    public static void Main(string[] args)
    {
        //VD();
        Ex04();
        Console.ReadLine();
    }
    public static void swap(ref int x, ref int y)
    {
        int z = 0;
        z = x;
        x = y;
        y = z;
    }
    public static void VD()
    {
        //Console.Write("Nhap a: "); int a=int.Parse(Console.ReadLine());
        //Console.Write("Nhap b: "); int b=int.Parse(Console.ReadLine());
        int a = 9;
        int b = 10;
        Console.WriteLine($"Truoc: a = {a}, b={b}");
        swap(ref a, ref b);
        Console.WriteLine($"sau: a = {a}, b={b}");
    }
    public static float max(ref float a, ref float b, ref float c)
    {
        float m = Math.Max(Math.Max(a, b), c);
        return m;
    }
    public static void Ex01()
    {
        Console.Write("Nhap so thu nhat: __"); float x = float.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: __"); float y = float.Parse(Console.ReadLine());
        Console.Write("Nhap so thu ba: __ "); float z = float.Parse(Console.ReadLine());
        float kq = max(ref x, ref y, ref z);
        Console.WriteLine($"So lon nhat trong ba la {kq}");
    }
    static int giaithua(int a)
    {
        int GT = 1;
        for (int i = 1; i <= a; i++)
            GT = GT * i;
        return GT;
    }
    public static void Ex02()
    {
        Console.Write("Nhap so nguyen duong: __");
        int x = int.Parse(Console.ReadLine());
        bool nhap = true;
        do
        {

            if (x >= 0)
                break;
            else
                nhap = false;
            Console.WriteLine("Ban can nhap mot so nguyen duong!");
        }
        while (true);
        int kq = giaithua(x);
        Console.WriteLine($"{x}! = {kq}");
    }
    static int checkPrime(int a)
    {
        int count = 0;
        for (int i = 2; i < a - 1; i++)
        {
            if ((a % i) == 0)
            {
                count++;
            }
        }

        return count;
    }
    public static void Ex03()
    {
        Console.Write("Nhap so nguyen bat ky: __"); int n = int.Parse(Console.ReadLine());
        int kq = checkPrime(n);
        if (n == 0)
        {
            Console.WriteLine("day la so nguyen to!");
        }
        else
        {
            Console.WriteLine("Day khong phai so nguyen to!");
        }
    }
    /// <summary>
    /// 1.in ra so nguyen to nho hon x.
    /// 2. in ra x so nguyen to dau tin.
    /// </summary>
    public static void Ex04()
    {
        Console.Write("Nhap mot so nguyen duong: __"); int x = int.Parse(Console.ReadLine());
        Console.Write($"Cac so nguyen to nho hon {x} la: ");
        for (int i = 2; i < x; i++)
        {
            if (checkPrime(i) == 0)
                Console.Write($"{i} ");
        }
        Console.WriteLine();
        Console.Write("Ban muon in ra bao nhieu so nguyen to dau tien? __"); int n = int.Parse(Console.ReadLine());


        Console.Write($"{n} so nguyen to dau tien la:  ");
        int count = 0;

        for (int i = 2; count < n; i++)
        {
            if (checkPrime(i) == 0)
            {
                Console.Write($"{i} ");
                count++;
            }
        }
    }
    public static bool checkPerfectNum(ref int x)
    {
        bool ktra = false;
        int sum = 0;
        for (int j = 1; j < x; j++)
        {
            if (x % j == 0)
            {
                sum += j;
            }
        }
        if (sum == x)
        {
            ktra = true;
        }
        return ktra;
    }
    public static void Ex05()
    {
        Console.Write("Nhap so can kiem tra: __"); int a = int.Parse(Console.ReadLine());
        if (checkPerfectNum(ref a) == true)
        { Console.WriteLine($"{a} la so hoan hao"); }
        else
        { Console.WriteLine($"{a} khong phai so hoan hao"); }
        Console.Write("Cac so hoan hao tu 1 den 1000  ");
        for (int i = 1; i < 1000; i++)
        {
            if (checkPerfectNum(ref i) == true)
            {
                Console.Write($"{i} ");
            }

        }
    }

    /// <summary>
    /// kiem tra 1 cau co phai la pangram khong </br>(tat ca chu trong bang chu cai xuat hien it nhat mot lan)
    /// </summary>
    public static void Ex06()
    {
        Console.WriteLine("Moi nhap mot cau: "); string s = Console.ReadLine();
        int count = 0;
        for (int i = 65; i <= 90; i++)
            if (s.ToUpper().Contains((char)i))
            {
                count++;
            }
        if (count >= 26)
        { Console.WriteLine("Ban vua nhap mot chuoi pangram!"); }
        else { Console.WriteLine("Day khong phai la chuoi pangram"); }
    }

}
