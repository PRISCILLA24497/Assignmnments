using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex3
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Palindrome" in both code and config file together.
	public class Palindrome : IPalindrome
	{
		public string palindrome(string S1,string rev)
		{
			for (int i = S1.Length - 1; i >= 0; i--)
			{
				rev += S1[i];
			}

			if (S1 == rev)
			{
				return "Palindrome";
			}
			else
			{
				return "not Palindrome";
			}
		}
	}
}
