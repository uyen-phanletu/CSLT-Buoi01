namespace Buoi01_A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System. Text.Encoding.UTF8;
            // NHẬP
            double a = 10, b = 10;
            // XỬ LÝ
            double cv = 2 * (a + b);
            double dt = a * b;
            // XUẤT
            Console.WriteLine(" Chiều dài   = " + a);
            Console.WriteLine(" Chiều rộng  = " + b);
            Console.WriteLine(" Chu vi      = " + cv);
            Console.WriteLine(" Diện tích   = " + dt);
        }
    }
}
