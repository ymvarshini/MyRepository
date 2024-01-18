using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class yesorno
    {
        int num;
        char ch = 'y';
        public void GetDetails()
        {
            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            do
            {
                Console.Clear();
                GetDetails();
                Console.WriteLine($"{num}*{num}={num * num}");
                ch = Convert.ToChar(Console.ReadLine().ToLower());
            }
            while (ch == 'y');
        }
    }

    }
}
