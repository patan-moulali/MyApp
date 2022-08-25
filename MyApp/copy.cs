using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace ReuseableCodeLibrary
{
    public class StringOperation
    {
        public static void Compare()
        {
            //Program 1
            Console.Write("Enter a string: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter another string: ");
            string s2 = Console.ReadLine();
            if (s1 == s2)
                Console.WriteLine("\"{0}\" and \"{1}\" are equal", s1, s2);
            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", s1, s2);
        }
        public static void Copy()
        {
            //Program 2
            Console.WriteLine("Enter a string: ");
            string s1 = Console.ReadLine();
            var s = string.Copy(s1);
            Console.WriteLine("Copy of String: \n" + s);
            Console.ReadLine();
        }
        public static void Indexof()
        {
            //Program 3
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter character to show index: ");
            char ch = Convert.ToChar(Console.ReadLine());
            int indexofch = s.IndexOf(ch);
            Console.WriteLine("Index of given character is: " + indexofch);

        }
        public static void Split()
        {
            //Program 4
            string newStr = "Welcome to the world of C# Programming";
            string[] sep = { "#" };
            int cnt = 2;
            string[] result = newStr.Split(sep, cnt, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static void Uppercase()
        {
            //Program 5
            Console.WriteLine("Enter a String: ");
            string s = Console.ReadLine();
            string s1 = s.ToUpper();
            Console.WriteLine("Converted String: " + s1);
        }
        public class FileandDate
        {
            public static void Makefile()
            {
                //Program 6
                string path = @"C:\Users\new\Documents\Demo\demo.txt";
                File.Create(path);
            }
            public static void Datedetails()
            {
                //Program 7
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                Console.WriteLine(dt);
                Console.WriteLine("\n");
                Console.WriteLine("Year= " + dt.Year);
                Console.WriteLine("Month= " + dt.Month);
                Console.WriteLine("Day= " + dt.Day);
                Console.WriteLine("Hour= " + dt.Hour);
                Console.WriteLine("Minute= " + dt.Minute);
                Console.WriteLine("Seconds= " + dt.Second);
                Console.WriteLine("Milliseconds= " + dt.Millisecond);

            }
        }
    }
}
