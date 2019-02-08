using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practical5_1_
{
    class Program
    {
      

        static void Main()
        {
            StreamReader reader = new StreamReader("teststream.txt");
            using (reader)
            {
                int lineNumber = 0;
                String line = reader.ReadLine();
                while(line!=null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}:{1}", lineNumber, line);
                    line = reader.ReadLine();
                }
                Console.ReadLine();
            }
        }
    }
}
