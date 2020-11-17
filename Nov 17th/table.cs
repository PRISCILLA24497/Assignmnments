using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex3
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "table" in both code and config file together.
	public class table : Itable
	{
		public int sum(int i , int s)
		{
			while (i <= 5)
			{
				s += i;
				i++;
			}
			
	return s;

		}

	}
	}

