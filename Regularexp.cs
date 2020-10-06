using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//Example 1:
namespace Regexp
{
    class Program
    {
        
            static bool IsValid(string value)
            {
                return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
            }

            static void Main(string[] args)
            {
                // Test the strings with the IsValid method.
                Console.WriteLine(IsValid("priscilla0203"));
                Console.WriteLine(IsValid("Katherine1234"));
                Console.WriteLine(IsValid("monica"));
                Console.WriteLine(IsValid(":-)"));
                // Console.WriteLine(IsValid(null)); // Throws an exception
                Console.ReadKey();

           //Apply regex and find for matchvalue.value = 99, value = 55 * ******

          //  Step:1=>> Create a regex - Object need to be created
          //  Digit or not
            Regex r = new Regex(@"\d+");//Find the digits present/match in the string.
            Match m= r.Match("Priscilla32");
            Match ma = r.Match("830410");
            if (m.Success)
            {
                Console.WriteLine("The match value of digit:" + m.Value);
            }


            // ********without creating instance of regex using static *************

            string input = "/content/alternate-1.aspx";

            // Part 2: call Regex.Match.
            Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
              RegexOptions.IgnoreCase);

            // Part 3: check the Match for Success.
            if (match.Success)
            {
                // Part 4: get the Group value and display it.
                string key = match.Groups[1].Value;
                Console.WriteLine(key);
            }



            // START ,END MATCHING
            //1st example
            string test = "sweety";
            //Match the start of a string

            if (Regex.IsMatch(test, "^sw"))
            {
                Console.WriteLine("start matches");//start matches
            }
            if (Regex.IsMatch(test, "ty$"))
            {
                Console.WriteLine("End matches");//end marches

            }


           // Second example
            string test1 = "priscilla24497@gmail";
            //Match the start

            if (Regex.IsMatch(test1, "^priscilla"))
            {
                Console.WriteLine("start match");
            }
            if (Regex.IsMatch(test, "@gmail$"))
            {
                Console.WriteLine("end match");
            }

            //NEXT MATCH //
            string value = "40 and 50";
            Match m1 = Regex.Match(value, @"\d");
            if (m1.Success)
            {
                Console.WriteLine(m1.Value);

            }
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine(match.Value);

            }




            string val = "434542";
            Match m2 = Regex.Match(value, @"\d");
            if (m2.Success)
            {
                Console.WriteLine(m2.Value);//

            }
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine(match.Value);//

            }
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine(match.Value);//

            }
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine(match.Value);//

            }

            //REPLACE//
            Regex regex = new Regex(@"\d");
            string s = regex.Replace("priscilla 12233 64646", " katherine");
            Console.WriteLine("input {0}", input);

            //GREEDY MATCHING//

            string st = "/priscilla/katherine/";

            //case1:Lazy 
            var res = Regex.Match(st, "^/.*?/");//? sweet
            if (res.Success)
            {
                Console.WriteLine("NON-GREEDY: {0}", res.Value);
            }
            //case2.Default regex
            var res1 = Regex.Match(st, "^/.*/");//? sweety
            if (res1.Success)
            {
                Console.WriteLine("NON-GREEDY: {0}", res1.Value);
            }


           //MATCH PARSE NUMBERS
            //Ex 1:
            string input1 = "Dot Net 100 Perls";
            Match x = Regex.Match(input1, @"\d+");
            if (x.Success)
            {
                int.TryParse(match.Value, out int number);
                // Show that we have the numbers.
                Console.WriteLine("NUMBERS: {0}, {1}", number, number + 1);
            }

     //   Ex: 2
            string str = "programmin is 14 15 16 is fun";
            Match y = Regex.Match(str, @"\d+");
            if (y.Success)
            {
                int.TryParse(match.Value, out int number);
                // Show that we have the numbers.
                Console.WriteLine("NUMBERS: {0}, {1}", number, number + 1);
            }



            //VALUE INDEX LENGTH

          //  Ex1
            Match a = Regex.Match("123 Axxxxy", @"A.*y");
            if (a.Success)
            {
                Console.WriteLine("Value  = " + a.Value);
                Console.WriteLine("Length = " + a.Length);
                Console.WriteLine("Index  = " + a.Index);
            }


//Ex2
            Match b = Regex.Match("123 Axxxxy", @"A.*y");
            if (b.Success)
            {
                Console.WriteLine("Value  = " + b.Value);
                Console.WriteLine("Length = " + b.Length);
                Console.WriteLine("Index  = " + b.Index);
            }






            Console.ReadKey();
        }
    }
}
    







                