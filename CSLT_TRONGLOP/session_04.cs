using System;
using System.Linq;

class Program
{
    // 1. Tính giá trị trung bình của các phần tử trong mảng
    static double Average(int[] arr)
    {
        int tong = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            tong += arr[i];    // xuất từng số trong index . Vd arr [0]= 2; 
        }
        return tong;
    }

    // 2. Kiểm tra mảng có chứa một giá trị cụ thể không
    static bool checkifcontains(int[] arr, int value)
    {
        // kiểm tra từng phần tử của mảng bằng vòng lặp for 
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return true;
            }
        }
        return false;
    }
    
    // 3. Tìm chỉ số của một phần tử trong mảng
    static int FindIndex(int[] arr, int value)   //thêm int value vì value là phần tử mới cần truyền 
    {
        // duyệt qua phàn tử mảng
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return i; // trả về giá trị chỉ số index 
            }

        }
        return -1;
    }

    // 4. Loại bỏ một phần tử khỏi mảng
    static int[] XoaPhanTu(int[] arr, int value)
    {
        // Tìm vị trí của phần tử cần xóa
        int index = Array.IndexOf(arr, value);

        if (index == -1)
        {
            // Nếu phần tử không tồn tại trong mảng, trả về mảng ban đầu
            Console.WriteLine("Phần tử không tồn tại trong mảng.");
            return arr;
        }

        // Tạo mảng mới có kích thước nhỏ hơn 1
        int[] newArr = new int[arr.Length - 1];

        // Sao chép các phần tử trước phần tử cần xóa
        Array.Copy(arr, 0, newArr, 0, index);

        // Sao chép các phần tử sau phần tử cần xóa
        Array.Copy(arr, index + 1, newArr, index, arr.Length - index - 1);

        return newArr;
    }

    // 5. Tìm giá trị lớn nhất và nhỏ nhất trong mảng
    static int FindMax(int[] arr)  // ko cần  static int FindMax(int[] arr, int max ) vì giá trị max có sẵn trong arr. chỉ cần tìm nó 
    {
        int max = arr[0]; // khởi tạo giá trị max ban đầu bằng phần tử đầu tiên của arr (có index=0 );
        for (int i = 0; i < arr.Length; i++)  //vòng lặp for sẽ duyệt qua tất cả các phần tử trong mảng, bắt đầu từ chỉ số i = 0 (phần tử đầu tiên)  đến i -chiều dài mảnh 
        {
            if (arr[i] > max) ; // nếu phần tử hiện tại lớn hơn giá trị max  (arr[i] là giá trị của mảng . VD mảng {3,4,1} thì arr[1]=4. 
            max = arr[i];  // max là giá trị lúc đó ;còn nếu giá trị lúc đó ko > max mới duyệt vd mảng 1 4 2 duyet toi 1: arr[2] = 1< 4 vẫn giữ nguyên. 
        }
        return max;

    }
    static int findmin(int[] arr)
    {
        int min = arr[0]; //khởi tạo min là phàn tử đầu tiên nằm ở index 0 
        foreach (var item in arr)
        {
            if (item < min)
                min = item;
        }
        return min;
    }

    // 6. Đảo ngược mảng
    static int[] ReverseArray(int[] arr)
    {
        Array.Reverse(arr);
        return arr;
    }

    // 7. Tìm các giá trị trùng lặp trong mảng
    static int[] FindDuplicateValues(int[] arr)
    {
        var duplicates = arr.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(g => g.Key)
                            .ToArray();
        return duplicates;
    }

    // 8. Loại bỏ các phần tử trùng lặp trong mảng
    static int[] RemoveDuplicates(int[] arr)
    {
        return arr.Distinct().ToArray();
    }

    static void Main()
    {
        Console.WriteLine("Nhap kich thuoc mang ");
        int kichthuoc = int.Parse(Console.ReadLine());

        //xuất giá trị mảng

        Random r = new Random();
        int[] mang1 = new int[kichthuoc];
        Console.WriteLine("xuất gia trị từng pt :  ");
        for (int i = 0; i < kichthuoc; i++)
        {
            mang1[i] = r.Next(0, 101);  //vd.mang1 [0] = 1 (i là số index < kichthuoc)  random: 0-> 100
            Console.WriteLine(mang1[i]);

        }

        // 1. Tính giá trị trung bình
        double trungbinh = Average(mang1) / mang1.Length;   //gọi hàm Average ( int[] arr)
        Console.WriteLine($"Nhap gia trị trung binh  :{trungbinh}");

        // 2. Kiểm tra mảng có chứa giá trị cu the 
        //nhập giá trị check 
        Console.WriteLine();
        Console.WriteLine("nhap gia tri can check: ");
        int giatricancheck = int.Parse(Console.ReadLine());
        //gọi hàm checkra 
        if (checkifcontains(mang1, giatricancheck))     // gọi checkifcontains : mang 1 = int[] arr, giatricancheck = value 
        {
            Console.WriteLine("Co chua phan tu cancheck ");
        }
        else
        {
            Console.WriteLine("ko chua phan tu cancheck");
        }


        // 3. Tìm chỉ số của phần tử có giá trị cancheck
        // Nhập giá trị cần tìm chỉ số
        Console.Write("Nhap gia tri can tim indeX ");
        int giatricantimchiso = int.Parse(Console.ReadLine());
        //gọi hàm
        int index = FindIndex(mang1, giatricantimchiso);
        if (giatricantimchiso != -1)
        {
            Console.WriteLine($"gia tri {giatricantimchiso} nằm trong chỉ so  {index}  của mảng ");
        }
        else
        {
            Console.WriteLine($" gia tri {giatricantimchiso} ko nằm trong mang ");
        }


        // 4. Loại bỏ phần tử có giá trị  khỏi mảng
        // Nhập phần tử cần xóa
        Console.WriteLine("\nNhập phần tử cần xóa:");
        int giatricanxoa = int.Parse(Console.ReadLine());

        // Gọi hàm xóa phần tử
        mang1 = XoaPhanTu(mang1, giatricanxoa);

        // Xuất mảng sau khi xóa phần tử
        Console.WriteLine("Mảng sau khi xóa phần tử:");
        foreach (var item in mang1)
        {
            Console.Write(item + " ");
        }

        // 5. Tìm giá trị lớn nhất và nhỏ nhất trong mảng
       

        // gọi hàm findmax 
        int solonnhat = FindMax(mang1);
        Console.WriteLine($"gia tri lon nhat : {solonnhat}");
        // gọi hàm min
        int sobenhat = findmin(mang1);
        Console.WriteLine($"Gia tri be nhat : {sobenhat}");


        // 7. Tìm các giá trị trùng lặp trong mảng
        var duplicates = FindDuplicateValues(mang1);
        Console.WriteLine("Các giá trị trùng lặp trong mảng:");
        foreach (int num in duplicates)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // 8. Loại bỏ các phần tử trùng lặp trong mảng
        mang1 = RemoveDuplicates(mang1);
        Console.WriteLine("Mảng sau khi loại bỏ phần tử trùng lặp:");
        foreach (int num in mang1)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
