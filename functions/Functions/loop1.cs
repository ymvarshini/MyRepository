using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class loop1
    {
        string name;
        int num;

        public void Display()
        {
            for (int i = 1; i <=num; i++)
            {
                Console.WriteLine($"{i}.{name}");
            }
        }

        internal void GetDetails()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());

        }
    }
}
