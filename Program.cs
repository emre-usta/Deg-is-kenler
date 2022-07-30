using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string str1 = "20";
            int int1 = 20;

            string yeniDeger = str1 + int1.ToString();
            Console.WriteLine(yeniDeger);

            int int2 = int1 + Convert.ToInt32(str1);
            Console.WriteLine(int2);

            int int3 = int1 + int.Parse(str1);
            Console.WriteLine(int3);
            
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string hour = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);
        }   
    }
}