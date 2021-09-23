using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.BinaryToDecimal
{
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("Chose mode:\n1.Convert ready examples\n2.Enter the number manually\n3.Exit");
            int choice;
            bool result = int.TryParse(Console.ReadLine(), out choice);
            while(result == false || choice <0 || choice > 4)
            {
                Console.Clear();
                Console.WriteLine("Operation input error,try again");
                Console.WriteLine("Chose mode:\n1.Convert ready examples\n2.Enter the number manually\n3.Exit");
                result = int.TryParse(Console.ReadLine(), out choice);
            }
            return choice;
        }

        static List<ulong> GetExamples()
        {
            List<ulong> examples = new List<ulong>();
            Random rand = new Random();
            string num = "";
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if ( j == 0 || j == 12)
                    {
                        num += "1";
                        continue;
                    }
                    num += rand.Next(0, 2).ToString();
                }
                examples.Add(ulong.Parse(num));
                num = "";
            }
            return examples;
            
        }

        static void Main(string[] args)
        {
            BinaryToDecimalConvert binaryToDecimal = new BinaryToDecimalConvert();
            bool stopButton = false;
            while (!stopButton)
            {
                switch (Menu())
                {
                    case 1:
                        List<ulong> list = GetExamples();
                        foreach(var el in list)
                        {
                            Console.WriteLine(el + " => " + binaryToDecimal.GetResult(el));
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter your binary number:");
                        double num;
                        bool convertCheck = double.TryParse(Console.ReadLine(), out num);
                        while (!convertCheck)
                        {
                            Console.Clear();
                            Console.WriteLine("Input error,try again");
                            Console.WriteLine("Enter your binary number:");
                            convertCheck = double.TryParse(Console.ReadLine(), out num);
                        }
                        Console.WriteLine("Result: " + num + " => " + binaryToDecimal.GetResult(num));
                        break;
                    case 3:
                        stopButton = true;
                        break;
                }
            }
            
        }
    }
}
