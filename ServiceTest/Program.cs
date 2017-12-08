using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthenticationService.WebService1SoapClient Login = new AuthenticationService.WebService1SoapClient();
            string firstname = "", lastname = "";

            Console.Write("Please enter your first name. \n");
            firstname = Console.ReadLine();
            Console.Write("Please enter your last name. \n");
            lastname = Console.ReadLine();

            if (Login.Login(firstname, lastname) == false)
            {
                Console.Write("You are not authorized here. Please see your administrator if you received this by mistake. \n");
            } else
            {
                Console.Write("Welcome to the Party. \n");
            }

        }
    }
}
