using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "res/appliances.txt";
            string[] resource = File.ReadAllLines(path);

            foreach (string line in resource)
            {
                string[] data = line.Split(';');
                
                int firstNum = int.Parse("0" + data[0][0]);

                Console.WriteLine(firstNum);






            }

            Console.ReadKey(); 

        }
    }
}
