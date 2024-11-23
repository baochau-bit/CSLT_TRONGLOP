using System;
using System.Linq;

class Program
{
    // 1. Tính giá trị trung bình của các phần tử trong mảng
    static double CalculateAverage(int[] arr)
    {
        if (arr.Length == 0) return 0;  // Nếu mảng rỗng, trả về 0
        int sum = arr.Sum();  // Tính tổng các phần tử trong mảng
        return (double)sum / arr.Length;  // Trả về giá trị trung bình
    }

    // 2. Kiểm tra mảng có chứa một giá trị cụ thể không
    static bool ContainsValue(int[] arr, int value)
    {
        return arr.Contains(value);
    }

    // 3. Tìm chỉ số của một phần tử trong mảng
    static int FindIndex(int[] arr, int value)
    {
        return Array.IndexOf(arr, value);
    }

    // 4. Loại bỏ một phần tử khỏi mảng
    static int[] RemoveElement(int[] arr, int value)
    {
        return arr.Where(x => x != value).ToArray();
    }

    // 5. Tìm giá trị lớn nhất và nhỏ nhất trong mảng
    static (int max, int min) FindMaxMin(int[] arr)
    {
        int max = arr.Max();
        int min = arr.Min();
        return (max, min);
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
        Random random = new Random();
        int[] arr = new int[10];  // Tạo mảng ngẫu nhiên với 10 phần tử

        // Tạo mảng ngẫu nhiên với giá trị từ 1 đến 100
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 101);
        }

        // In mảng ngẫu nhiên
        Console.WriteLine("Mảng ngẫu nhiên:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // 1. Tính giá trị trung bình
        double average = CalculateAverage(arr);
        Console.WriteLine($"Giá trị trung bình của mảng: {average}");

        // 2. Kiểm tra mảng có chứa giá trị 50 không
        Console.WriteLine($"Mảng có chứa giá trị 50 không? {ContainsValue(arr, 50)}");

        // 3. Tìm chỉ số của phần tử có giá trị 30
        int index = FindIndex(arr, 30);
        Console.WriteLine($"Chỉ số của phần tử 30 trong mảng: {index}");

        // 4. Loại bỏ phần tử có giá trị 30 khỏi mảng
        arr = RemoveElement(arr, 30);
        Console.WriteLine("Mảng sau khi loại bỏ giá trị 30:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // 5. Tìm giá trị lớn nhất và nhỏ nhất trong mảng
        var (max, min) = FindMaxMin(arr);
        Console.WriteLine($"Giá trị lớn nhất trong mảng: {max}");
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng: {min}");

        // 6. Đảo ngược mảng
        arr = ReverseArray(arr);
        Console.WriteLine("Mảng sau khi đảo ngược:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // 7. Tìm các giá trị trùng lặp trong mảng
        var duplicates = FindDuplicateValues(arr);
        Console.WriteLine("Các giá trị trùng lặp trong mảng:");
        foreach (int num in duplicates)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // 8. Loại bỏ các phần tử trùng lặp trong mảng
        arr = RemoveDuplicates(arr);
        Console.WriteLine("Mảng sau khi loại bỏ phần tử trùng lặp:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
