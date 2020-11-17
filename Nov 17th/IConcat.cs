using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryex3
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IForeach" in both code and config file together.
	[ServiceContract]
	public interface IConcat
	{
		[OperationContract]

		string Concats(string S1, string S2);


	}
}
[DataContract]
public class Concat
{
	[DataMember]
	public string S1;
	[DataMember]
	public string s2;

}