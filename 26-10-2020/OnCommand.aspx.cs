using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linkexample
{
	public partial class OnCommand : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void LinkButton1_Command(object sender, CommandEventArgs e)
		{
			Label1.Text = "You chose" + e.CommandName + "Item" + e.CommandArgument;
		}

		protected void LinkButton2_Command(object sender, CommandEventArgs e)
		{
			

		}
	}
}