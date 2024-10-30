internal class session_1
{
    private static void Main(string[] args)
    {
        // Question_01();
       //  Question_02();
        /*  Question_03();
         Question_04();
         Question_05();
         Question_06();
         Question_07();
         Question_08();
         Question_09();*/
   //Question_10();
    }
    public static void Question_01()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        Console.WriteLine($"Sum: {sum}");
    }
    public static void Question_02()
    {
        Console.Write("Enter first value: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second value: ");
        int b = Convert.ToInt32(Console.ReadLine());

        (a, b) = (b, a);

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
    public static void Question_03()
    {
        Console.Write("Enter first floating point number: ");
        float num1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter second floating point number: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        float product = num1 * num2;
        Console.WriteLine($"Product: {product}");
    }
    public static void Question_04()
    {
        Console.Write("Enter value in feet: ");
        float feet = Convert.ToSingle(Console.ReadLine());

        float meters = feet * 0.3048f;
        Console.WriteLine($"{feet} feet = {meters} meters");
    }
    public static void Question_05()
    {

    }
    public static void Question_06()
    {
        int s = sizeof(int);
        Console.WriteLine($"{s}");
    }
    public static void Question_07()
    {
        Console.Write("Enter a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine($"\nASCII value of '{ch}' is {(int)ch}");
    }
    public static void Question_08()
    {
        Console.Write("Enter radius of circle: ");
        float radius = Convert.ToSingle(Console.ReadLine());

        float area = (float)(Math.PI * radius * radius);
        Console.WriteLine($"Area of the circle: {area}");
    }
    public static void Question_09()
    {
        Console.Write("Enter side length of square: ");
        float side = Convert.ToSingle(Console.ReadLine());

        float area = side * side;
        Console.WriteLine($"Area of the square: {area}");
    }
    public static void Question_10()
    {
        Console.Write("Enter number of days: ");
        int days = Convert.ToInt32(Console.ReadLine());

        int years = days / 365;
        days %= 365;
        int weeks = days / 7;
        days %= 7;

        Console.WriteLine($"{years} years, {weeks} weeks, {days} days");
    }
}