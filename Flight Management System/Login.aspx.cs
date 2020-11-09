using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FlightAssignmenr
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("Select * from Flight1 where Name=@Name AND Password=@Password", con);





			cmd.Parameters.AddWithValue("@Name", TextBox1.Text);
			cmd.Parameters.AddWithValue("@Password", TextBox2.Text);

			
			cmd.Connection = con;
			int OBJ = Convert.ToInt32(cmd.ExecuteScalar());
			if (OBJ > 0)
			{
				Session["Name"] = TextBox1.Text;
				Response.Redirect("FlightBooking.aspx");
			}
			else
			{
				Label2.Text = "Invalid username or password";
			}





			con.Close();
		}
	

		
			protected void Button1_Click(object sender, EventArgs e)
		{
			Response.Redirect("FlightTicketbooking.aspx");
		}

		protected void Button3_Click(object sender, EventArgs e)
		{
			Response.Redirect("Register.aspx");
		}
	}
}
