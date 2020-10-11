using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//Checcking valid email id and phonenumber using regular expressiond
namespace Regular_expressions
{
    class c
    {
        static void Main(string[] args)
        {
            string[] str1 = {"9925612824",
          "8238783138", "02812451830"};

            string[] str2 = {"prisci@gmail.com",
                  "priscillak$gmail.com",
                            "@gmail.com"};


            foreach (string s in str1)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s,
                            isValidMobileNumber(s) ? "is" : "is not");
            }
            Console.WriteLine("***********************************************************************");
            Console.ReadKey();


            // Input strings for Match 
            // valid E-mail address. 

            foreach (string s in str2)
            {
                Console.WriteLine("{0} {1} a valid E-mail address.", s,
                                    isValidEmail(s) ? "is" : "is not");
               
            }
            Console.ReadLine();



        }
        // Method to check the Email ID 
        public static bool isValidEmail(string inputEmail)
        {

            // This Pattern is use to verify the email 
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(strRegex);

            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public static bool isValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9] 
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            Regex rx = new Regex(strRegex);


            if (rx.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }
    }
}
