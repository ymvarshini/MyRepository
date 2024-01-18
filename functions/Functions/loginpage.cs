using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Loginpage
    {
        string username;
        string password;
        public void GetDetails()
        {
            Console.WriteLine("enter the username");
            username = Console.ReadLine();
            Console.WriteLine("enter the password");
            password = Console.ReadLine();
        }
        public bool ValidateUser(string username, string password)
        {
            if (username == "madhu" && password == "M@dhu")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DisplayResult()
        {
            if(ValidateUser(username, password))
            {
                Console.WriteLine("LoginSuccessful");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }
       
    }

 }
