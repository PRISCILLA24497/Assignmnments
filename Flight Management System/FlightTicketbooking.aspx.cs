using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightAssignmenr
{
	public partial class FlightTicketbooking : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button3_Click(object sender, EventArgs e)
		{
			
				Response.Redirect("Register.aspx");
			}

		protected void Button4_Click(object sender, EventArgs e)
		{
	Response.Redirect("Login.aspx");
}

		protected void Button5_Click(object sender, EventArgs e)
		{
	Response.Redirect("Admin.aspx");
}

		protected void Button6_Click(object sender, EventArgs e)
		{

	Response.Redirect("ContactPage.aspx");
}

		protected void Button12_Click(object sender, EventArgs e)
		{
	Response.Redirect("TicketGeneration.aspx");
}
	}
}