using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Menu
    {
        int num1, num2;
        char ch;
        public void GetDetails()
        {
            Console.WriteLine("enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a symbol");
            ch = Convert.ToChar(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            int result = 0;
            switch (ch)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }
            Console.WriteLine($"Result of {num1} {ch} {num2} is {result}"); 
}
}
}