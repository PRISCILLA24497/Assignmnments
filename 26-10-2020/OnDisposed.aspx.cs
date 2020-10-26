using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linkexample
{
	public partial class OnDisposed : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void LinkButton1_Disposed(object sender, EventArgs e)
		{
			Label1.Text = "Hello World";
		}
	}
}