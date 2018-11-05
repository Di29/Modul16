using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesHomeworkkk
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        private static void SecondTask()
        {
            Random random = new Random();
            string input_path = "input.txt";
            string output_path = "output.txt";

            if (!File.Exists(input_path))
            {
                File.Create(input_path);
            }
            if (!File.Exists(output_path))
            {
                File.Create(output_path);
            }
            using(StreamWriter writer = new StreamWriter(input_path, false))
            {
                int num1 = random.Next(1, 49); 
                writer.Write(num1.ToString());
            }
            using (StreamWriter writer = new StreamWriter(input_path, true))
            {
                int num2 = random.Next(50, 100);
                writer.Write(" " + num2.ToString());
            }

            string str;
            using (StreamReader reader = new StreamReader(input_path))
            {
                str = reader.ReadLine();
            }
            var numbers = NumberParser(str);
            int sum = 0;
            numbers.ForEach(number => sum += number);
            using (StreamWriter writer = new StreamWriter(output_path))
            {
                writer.Write(sum);
            }
        }

        private static List<int> NumberParser(string str)
        {
            List<int> numbers = new List<int>();
            string tmp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    tmp += str[i];
                }
                else
                {
                    numbers.Add(int.Parse(tmp));
                    tmp = "";
                }
            }
            numbers.Add(int.Parse(tmp));
            return numbers;
        }
        private static void FirstTask()
        {
            string fibonacciNumbers = "1 1 2 3 5";
            string path = "FibonacciNumbers.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using(StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(fibonacciNumbers);
            }

            string str;
            using (StreamReader reader = new StreamReader(path))
            {
                str = reader.ReadLine();
            }

            var numbers = NumberParser(str);
            int count = numbers.Count;

            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[i + count - 2] + numbers[i + count - 1]);
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                numbers.ForEach(number => writer.Write(number + " "));
            }
            
        }
    }
}