using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class loop2
    {
        string name;
        int num;
        public void GetDetails()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            int i = 1;
            while (i <= num)
            {
                Console.WriteLine($"{i}.{name}");
                i++;
            }
        }
    }
}
