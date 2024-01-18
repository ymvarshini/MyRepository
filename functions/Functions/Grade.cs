using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Grade
    {
        int m1, m2, m3, m4, m5, m6, average;
        public void GetDetails()
        {
            Console.WriteLine("enter marks of first subject");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks of second subject");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks of third subject");
            m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks of fourth subject");
            m4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks of fifth subject");
            m5 = Convert.ToInt32(Console.ReadLine());

        }
        private string CalculateGrade(int average)
        {
            if(average >= 80 && average <= 100)
                return "first";
            else if (average >= 50 && average < 80)
               
                    return "second";
               
                else if (average >= 30 && average < 50)
               
                    return "third";
                
                else if (average >= 0 && average < 30)
                
                    return "fail";
                
                else
                
                    return "invalid marks";
            }
            public void DisplayDetails()
            {
            Console.WriteLine($"({average} = {m1}+{m2}+{m3}+{m4}+{m5})/5");
            string Grade = CalculateGrade(average);
            }
        }
}
