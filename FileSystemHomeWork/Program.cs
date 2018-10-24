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
            long fileSize = new FileInfo(filePath).Length;

            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                if(fileSize == 0)
                {
                    using (StreamWriter writer = new StreamWriter()
                }
                using (StreamReader reader = new StreamReader(filePath))
                {
                    reader.Rea
                }
            }
        }
    }
}
