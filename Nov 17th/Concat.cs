using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex3
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Foreach" in both code and config file together.
	public class Concat : IConcat
	{
		public string Concats(string S1,string S2)

		{
			return S1 + S2;
		}
	}
}
