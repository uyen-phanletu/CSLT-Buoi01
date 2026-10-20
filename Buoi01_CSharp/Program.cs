
using System;

namespace Buoi01_B3
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // sửa: thêm dấu ;

            Console.WriteLine("Chương trình có lỗi"); // sửa: viết hoa Console, thêm dấu nháy kép đóng và dấu );

            Console.WriteLine(@"Đường dẫn: C:\Temp\new"); // sửa: dùng @ để giữ nguyên dấu \ trong đường dẫn

            Console.WriteLine("Kết thúc"); // sửa: dùng dấu nháy kép thay cho nháy đơn
        }
    }
}
