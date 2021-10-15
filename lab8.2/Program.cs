using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "log.txt";//задаем путь к файлу
            Random random = new Random();
            int[] array = new int[100];//переменная для массива чисел
            int sum = 0;//переменная для суммы
            int j = 0;

            using (StreamWriter sw = new StreamWriter(path))//создаем файл по указанному пути и записываем в него массив чисел
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 200);
                    sw.Write("{0} ", array[i]);
                }
            }

            using (StreamReader sr = new StreamReader(path))//считываем полученную строку из файла
            {

                string s = sr.ReadLine();//присваиваем строку в новую переменную
                Console.WriteLine(s);//выводим ее на консоль

                string number = String.Empty;
                for (int i = 0; i < s.Length; i++)//из полученной строки достаем числа и считаем сумму
                {
                    if (s[i] != ' ')
                    {
                        number += s[i];
                    }
                    else
                    {
                        j = Convert.ToInt32(number, 10);
                        sum += j;
                        number = String.Empty;
                    }
                    
                }
                Console.Write("Сумма чисел равна {0} ", sum);

          
            }
            Console.ReadKey();
        }
    }
}
