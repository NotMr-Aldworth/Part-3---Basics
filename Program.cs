using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3___Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            
            Console.WriteLine("What is your favourite Number?!");
            response = Console.ReadLine();
            Convert.ToInt32(response);
            Console.WriteLine($"Your favorite number is  {response} ");

            Console.ReadLine();


        }
    }
}
