using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace linkexample
{
	public partial class link : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void LinkButton1_Click(object sender, EventArgs e)
		{
			Label1.Text = "Welcome to Instagram";
		}

		protected void LinkButton2_Click(object sender, EventArgs e)
		{
			Label2.Text = "Welcome to Facebook";
		}

		protected void LinkButton2_Click1(object sender, EventArgs e)
		{
			Label3.Text = "Welcome to Twitter";

		}

		protected void LinkButton2_Load(object sender, EventArgs e)
		{

		}
	}
}