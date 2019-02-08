using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practical5_2_
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] Directories = Directory.GetDirectories(@"C:\Users\RICHA\source\repos");
            Console.WriteLine("All the Directories are:");
            foreach (string dir in Directories)
            {
                //Console.WriteLine("All the Directories are:");
                Console.WriteLine(dir);
            }
            string[] files = Directory.GetFiles(@"C:\Users\RICHA\source\repos");
            Console.WriteLine("All the Files are:");
            foreach (string file in files)
            {
               // Console.WriteLine("All the Files are:");
                Console.WriteLine(file);
            }
            Console.ReadLine();
        }
    }
}
