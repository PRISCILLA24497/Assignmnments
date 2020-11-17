using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex3
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPalindrome" in both code and config file together.
	[ServiceContract]
	public interface IPalindrome
	{
		[OperationContract]
		string palindrome(string S1,string rev);
	}
}
public class palindrome
{
	[DataMember]
	public string S1;
	
	
}