using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class loop3
    {
        string name;
        int num;
        public void GetDetails()
        {
            Console.WriteLine("enter a name");
            name = Console.ReadLine();
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            int i = 1;
            do
            {
                Console.WriteLine($"{i}.{name}");
                i++;
            }
            while (i < num);
        }



    }
}
