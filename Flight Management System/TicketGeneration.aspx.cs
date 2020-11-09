using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightAssignmenr
{
	public partial class TicketGeneration : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
			Label2.Text = Session["value"].ToString();
			Label4.Text = Session["value1"].ToString();
			Label5.Text = Session["value3"].ToString();
			Label6.Text = Session["value4"].ToString();
			Label7.Text = Session["value5"].ToString();
			Label8.Text = Session["value6"].ToString();


		}
	}
}