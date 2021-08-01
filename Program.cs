using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Dictionary<int, string>();
            student.Add(1, "Kamil Kemir");
            student.Add(2, "Famil Femir");
            student.Add(3, "Tamil Temir");
            student.Add(4, "Pamil Pemir");
            student.Add(5, "Zamil Zemir");
            Console.Write("Öğrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("Öğrenci Adı"+": "+student[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }
        }
    }
}
