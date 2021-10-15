using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "log.txt";
            int lines = 1;
            int words = 0;
            int chars = 0;


            using (StreamReader sr = new StreamReader(path))
            {

                string s = sr.ReadToEnd();
                Console.WriteLine(s);

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        words++;
                    }
                    if (s[i] == '\n')
                    {
                        lines++;                        
                    }
                    if (s != "" && s[i] != '\n' && s[i] != '\r')
                    {
                        chars++;
                    }
                }
            }


            Console.WriteLine("Количество строк - {0}, количество слов - {1}, количество символов - {2}", lines, words+lines, chars);
            Console.ReadKey();

        }
    }
}
