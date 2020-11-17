using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex3
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Itable" in both code and config file together.
	[ServiceContract]
	public interface Itable
	{
		[OperationContract]
		int sum(int i, int s);
	}
	
}
[DataContract]
public class Table
{
	[DataMember]
	public double s;
	[DataMember]
	public double i;
	
}