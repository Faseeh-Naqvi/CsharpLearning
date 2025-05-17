using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using calc;//use the namespace of that file, so we can call stuff from there 

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2025;//comments, current year
            string name = "Syed";//reference type, this is immutable
            char[] namea = new char[4] { 'S', 'y', 'e', 'd' };//array of characters
            namea[2] = 'b';
            double gpa = 3.7;
            Console.WriteLine($"{new string(namea)} is a student in {year} with a GPA of {gpa}");
            Console.WriteLine($"{name}-> {year} -> {gpa} cGPA");
            calcs calc = new calcs("bjhr804", 7);
            Console.WriteLine($"{calc.Square(year)} --> The year squared");
            //string inp = Console.ReadLine();
            //Console.WriteLine($"{calc.booleanCheck(inp)}--> The boolean value of the input");
            Console.WriteLine(calc.info());
            // for (int i = 0; i <= year; i++)
            // {
            //     if (i > year / 2)
            //     {
            //         i += 500;
            //     }
            //     Console.WriteLine(i);

            // }
        }
    }
}