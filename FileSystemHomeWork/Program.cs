using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            //SecondTask();
            

        }

        private static void SecondTask()
        {
            throw new NotImplementedException();
        }

        private static void FirstTask()
        {
            string directory = Directory.GetCurrentDirectory();
            string filePath = directory + @"\FibonacciNumbers.txt";
            //long fileSize = new FileInfo(filePath).Length;
            string[] fibonacciNumbers = {"0", "1", "1", "2", "3", "5", "8" };

            //using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            //{
            //    if(fileSize == 0)
            //    {
            //        using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.Default))
            //        {
            //            writer.Wr
            //        }
            //    }
            //    using (StreamReader reader = new StreamReader(filePath))
            //    {
            //        reader.Rea
            //    }
            //}

            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, fibonacciNumbers, Encoding.Default);
            }
            else
            {
                File.ReadAllLines()
            }
            
            
        }
    }
}
