using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Windows";
            string[] dirs = Directory.GetDirectories(path);

            foreach (string d in dirs)
            {
                Console.WriteLine(d);
            }
            
            Console.ReadKey();
        }
    }
}
